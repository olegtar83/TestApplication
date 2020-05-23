import { Component, OnInit } from '@angular/core';
import { IDepartment } from '../models/department';
import { HttpApiService } from '../services/http-api.service';


@Component({
  selector: 'departments-home',
  templateUrl: './departments.component.html',
})
export class DepartmentsComponent implements OnInit {

  constructor(private httpApi: HttpApiService) {}
  ngOnInit(): void {
    this.httpApi.getAllDepartments().subscribe(data => {
      this.departments = data;
    })
  }
  departments: IDepartment[];
  
}
