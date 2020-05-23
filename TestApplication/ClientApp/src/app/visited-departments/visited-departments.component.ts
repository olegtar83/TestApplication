import { Component, OnInit } from '@angular/core';
import { HttpApiService } from '../services/http-api.service';
import { IVisitedDepartments} from '../models/visitedDepartments';
import { from } from 'rxjs';

@Component({
  selector: 'app-visited-departments',
  templateUrl: './visited-departments.component.html'
})
export class VisitedDepartmentsComponent implements OnInit{
  constructor(private httpApi: HttpApiService) {}

  visitedDepartments: IVisitedDepartments[];

  ngOnInit(): void {
    this.httpApi.getMostVisitedDepartments().subscribe(data => {
      this.visitedDepartments = data;
    })
  }
}
