import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DotNetDemoAppRoutingModule } from './dotNetDemoApp-routing.module';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { FormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { MatButtonModule } from '@angular/material/button';
import { DotNetDemoAppComponent } from './components/dotNetDemoApp.component';
import { OrganizationTableComponent } from './components/organizationTable/organizationTable.component';
import { OrganizationService } from './components/services/organization.service';
import { LicenseTableComponent } from './components/licenseTable/licenseTable.component';
import { LicenseService } from './components/services/license.service';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { PopulateComponent } from './components/populate/populate.component';
import { Config } from './config';
import { HttpClientModule } from '@angular/common/http';
import { UpdateService } from './components/services/update.service';
import { MatSnackBarModule } from '@angular/material/snack-bar';



@NgModule({
  declarations: [
    DotNetDemoAppComponent, OrganizationTableComponent, LicenseTableComponent, DashboardComponent, PopulateComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatPaginatorModule,
    MatCheckboxModule,
    FormsModule,
    MatSelectModule,
    MatButtonModule,
    HttpClientModule,
    MatSnackBarModule,
    DotNetDemoAppRoutingModule
  ],
  providers: [OrganizationService, LicenseService, Config, UpdateService],
  bootstrap: [DotNetDemoAppComponent]
})
export class DotNetDemoAppModule { }
