import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Planner } from './planner.model';
import { catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class PlannerService {

    private plannersUrl = 'https://localhost:5001/api/planners'
    private httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
    constructor(private http: HttpClient) { }

    getPlanners(): Observable<Planner[]> {
        return this.http.get<Planner[]>(this.plannersUrl)
            .pipe(catchError(this.handleError<Planner[]>([])))
    }

    getPlanner(id: string): Observable<Planner> {
        const url = `${this.plannersUrl}/${id}`
        return this.http.get<Planner>(url)
            .pipe(catchError(this.handleError<Planner>()))
    }

    addPlanner(planner: Planner): Observable<Planner> {
        return this.http.post<Planner>(this.plannersUrl, planner, this.httpOptions)
            .pipe(catchError(this.handleError<Planner>()))
    }

    updatePlanner(planner: Planner): Observable<any> {
        return this.http.put<Planner>(this.plannersUrl, planner, this.httpOptions)
            .pipe(catchError(this.handleError<any>()))
    }

    deletePlanner(planner: Planner | string): Observable<Planner> {
        const id = typeof planner === 'string' ? planner : planner.id;
        const url = `${this.plannersUrl}/${id}`;

        return this.http.delete<Planner>(url, this.httpOptions)
            .pipe(catchError(this.handleError<Planner>()))
    }

    private handleError<T>(result?: T) {
        return (error: any): Observable<T> => {
            console.error(error);
            return of(result as T);
        };
    }
}
