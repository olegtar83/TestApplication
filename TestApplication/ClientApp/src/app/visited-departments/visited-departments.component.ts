import { Component } from '@angular/core';

@Component({
  selector: 'app-visited-departments',
  templateUrl: './visited-departments.component.html'
})
export class VisitedDepartmentsComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
