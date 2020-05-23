import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IVisitedDepartments } from '../models/visitedDepartments';
import { IDepartment } from '../models/department';
import { IActiveEmployees } from '../models/activeEmployees';


@Injectable({
  providedIn: 'root'
})
export class HttpApiService {
  constructor(private http: HttpClient) { }

  private baseUrl: string = '';

  public getAllDepartments(): Observable<IDepartment[]>{
    return this.http.get<any>(`${this.baseUrl}api/Common/getDepartments`); 
  }
  public getMostActiveEmployees(): Observable<IActiveEmployees[]>{
    return this.http.get<any>(`${this.baseUrl}api/Common/getMostActiveEmployees`); 
  }
  public getMostVisitedDepartments(): Observable<IVisitedDepartments[]>{
    return this.http.get<any>(`${this.baseUrl}api/Common/getMostVisitedDepartments `); 
  }
}
