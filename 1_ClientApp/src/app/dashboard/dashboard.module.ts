import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HomeComponent } from '../pages/home/home.component';
import { ClientsComponent } from '../pages/clients/clients.component';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';


@NgModule({
  imports: [
    DashboardRoutingModule
    ],
  declarations: [
      HomeComponent, 
      ClientsComponent,
      DashboardComponent
  ],
   providers: [],

})
export class DashboardModule { }
