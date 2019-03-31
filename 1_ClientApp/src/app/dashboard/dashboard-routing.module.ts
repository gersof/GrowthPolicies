import { NgModule } from '@angular/core';
import { Routes,
     RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from '../pages/home/home.component';
import { ClientsComponent } from '../pages/clients/clients.component';



const routes: Routes = [
  {
    path: '',
    component: DashboardComponent,
    data: {
      title: 'Dashboard'
    }
  },
  {
    path: 'home',
    component: HomeComponent,
    data: {
      title: 'Home Page'
    }
  },
  {
    path: 'clients',
    component: ClientsComponent,
    data: {
      title: 'Clients Page'
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes),  ],
  exports: [RouterModule]
})
export class DashboardRoutingModule {}
