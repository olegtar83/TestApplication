import { Component, OnInit } from '@angular/core';
import { IActiveEmployees } from '../models/activeEmployees';
import { HttpApiService } from '../services/http-api.service';
@Component({
  selector: 'app-active-employees',
  templateUrl: './active-employees.component.html'
})
export class ActiveEmployeesComponent implements OnInit {

activeEmployees: IActiveEmployees[];

constructor(private httpApi: HttpApiService) {}
  ngOnInit(): void {
    this.httpApi.getMostActiveEmployees().subscribe(data => {
      this.activeEmployees = data;
    })
  }
}

