import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { PopulateComponent } from './components/populate/populate.component';


const routes: Routes = [
  { path: 'dashboard', component: DashboardComponent, data: { animation: 'Dashboard'} },
  { path: 'populate', component: PopulateComponent, data: { animation: 'Populate' } },
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { enableTracing: false, useHash: true })],
  exports: [RouterModule]
})
export class DotNetDemoAppRoutingModule { }
