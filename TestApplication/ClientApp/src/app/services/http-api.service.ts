import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { VisitedDepartments } from '../models/visitedDepartments';
import { Department } from '../models/department';
import { ActiveEmployees } from '../models/activeEmployees';


@Injectable({
  providedIn: 'root'
})
export class HttpApiService {
  constructor(private http: HttpClient) { }

  private baseUrl: string = '';

  public getAllDepartments(): Observable<Department>{
    return this.http.get<any>(`${this.baseUrl}api/Meeting/getDepartments`); 
  }
  public getMostActiveUsers(): Observable<ActiveEmployees>{
    return this.http.get<any>(`${this.baseUrl}api/Meeting/getMostActiveEmployees`); 
  }
  public getMostVisitedDepartments(): Observable<VisitedDepartments>{
    return this.http.get<any>(`${this.baseUrl}api/Meeting/getMostVisitedDepartmentsng `); 
  }
}
