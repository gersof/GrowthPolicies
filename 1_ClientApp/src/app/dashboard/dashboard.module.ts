import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HomeComponent } from '../pages/home/home.component';
import { ClientsComponent } from '../pages/clients/clients.component';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CreatePolicyComponent } from '../pages/create-policy/create-policy.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { NgZorroAntdModule, NZ_I18N, en_US } from 'ng-zorro-antd';



@NgModule({
  imports: [
    DashboardRoutingModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgZorroAntdModule
  ],
  declarations: [
    HomeComponent,
    ClientsComponent,
    DashboardComponent,
    CreatePolicyComponent
  ],
  providers: [],

})
export class DashboardModule { }
