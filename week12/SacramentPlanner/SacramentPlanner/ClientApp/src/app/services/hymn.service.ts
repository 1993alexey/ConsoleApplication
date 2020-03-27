import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Hymn } from '../models/hymn.model';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HymnService {

  private hymnsUrl = 'https://localhost:5001/api/hymns'
  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  constructor(private http: HttpClient) { }

  getHymns(): Observable<Hymn[]> {
    return this.http.get<Hymn[]>(this.hymnsUrl)
      .pipe(catchError(this.handleError<Hymn[]>([])))
  }

  getHymn(id: string): Observable<Hymn> {
    const url = `${this.hymnsUrl}/${id}`
    return this.http.get<Hymn>(url)
      .pipe(catchError(this.handleError<Hymn>()))
  }

  addHymn(hymn: Hymn): Observable<Hymn> {
    return this.http.post<Hymn>(this.hymnsUrl, hymn, this.httpOptions)
      .pipe(catchError(this.handleError<Hymn>()))
  }

  updateHymn(hymn: Hymn): Observable<any> {
    return this.http.put<Hymn>(this.hymnsUrl, hymn, this.httpOptions)
      .pipe(catchError(this.handleError<any>()))
  }

  deleteHymn(hymn: Hymn | string): Observable<Hymn> {
    const id = typeof hymn === 'string' ? hymn : hymn.id;
    const url = `${this.hymnsUrl}/${id}`;

    return this.http.delete<Hymn>(url, this.httpOptions)
      .pipe(catchError(this.handleError<Hymn>()))
  }

  private handleError<T>(result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }
}
