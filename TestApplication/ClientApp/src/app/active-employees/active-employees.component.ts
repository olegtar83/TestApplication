import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-active-employees',
  templateUrl: './active-employees.component.html'
})
export class ActiveEmployeesComponent {

  // constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  //   http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
  //     this.forecasts = result;
  //   }, error => console.error(error));
  // }
}

