import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { IVisitedDepartments } from '../models/visitedDepartments';
import { IDepartment } from '../models/department';
import { IActiveEmployees } from '../models/activeEmployees';
import { tap, catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class HttpApiService {
  constructor(private http: HttpClient) { }

  private baseUrl: string = '';

  public getAllDepartments(): Observable<IDepartment[]>{
    return this.http.get<any>(`${this.baseUrl}api/Common/getDepartments`).pipe(
      catchError(this.handleError<any>('get'))
    ); 
  }
  public getMostActiveEmployees(): Observable<IActiveEmployees[]>{
    return this.http.get<any>(`${this.baseUrl}api/Common/getMostActiveEmployees`).pipe(
      catchError(this.handleError<any>('get'))
    ); 
  }
  public getMostVisitedDepartments(): Observable<IVisitedDepartments[]>{
    return this.http.get<any>(`${this.baseUrl}api/Common/getMostVisitedDepartments `).pipe(
      catchError(this.handleError<any>('get'))
    );
  }
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.log(error.error.title); // log to console instead

      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.title}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
