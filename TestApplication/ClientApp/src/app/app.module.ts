import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { DepartmentsComponent } from './departments/departments.component';
import { VisitedDepartmentsComponent } from './visited-departments/visited-departments.component';
import { ActiveEmployeesComponent } from './active-employees/active-employees.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    DepartmentsComponent,
    VisitedDepartmentsComponent,
    ActiveEmployeesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: DepartmentsComponent, pathMatch: 'full' },
      { path: 'departments', component: DepartmentsComponent },
      { path: 'visited-departments', component: VisitedDepartmentsComponent },
      { path: 'active-employees', component: ActiveEmployeesComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
