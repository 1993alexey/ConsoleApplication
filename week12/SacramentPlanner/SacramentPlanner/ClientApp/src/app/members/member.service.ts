import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Member } from './member.model';
import { catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class MemberService {

    private membersUrl = 'https://localhost:5001/api/members'
    private httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
    constructor(private http: HttpClient) { }

    getMembers(): Observable<Member[]> {
        return this.http.get<Member[]>(this.membersUrl)
            .pipe(catchError(this.handleError<Member[]>([])))
    }

    getMember(id: string): Observable<Member> {
        const url = `${this.membersUrl}/${id}`
        return this.http.get<Member>(url)
            .pipe(catchError(this.handleError<Member>()))
    }

    addMember(member: Member): Observable<Member> {
        return this.http.post<Member>(this.membersUrl, member, this.httpOptions)
            .pipe(catchError(this.handleError<Member>()))
    }

    updateMember(member: Member): Observable<any> {
        console.log(member)
        return this.http.put<Member>(`${this.membersUrl}/${member.id}`, member, this.httpOptions)
            .pipe(catchError(this.handleError<any>()))
    }

    deleteMember(member: Member | string): Observable<Member> {
        const id = typeof member === 'string' ? member : member.id;
        const url = `${this.membersUrl}/${id}`;

        return this.http.delete<Member>(url, this.httpOptions)
            .pipe(catchError(this.handleError<Member>()))
    }

    private handleError<T>(result?: T) {
        return (error: any): Observable<T> => {
            console.error(error);
            return of(result as T);
        };
    }
}
