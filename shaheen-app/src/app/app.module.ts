import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MaterialModule } from './material/material.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { MasterComponent } from './master/master.component';
import { CountryComponent } from './country/country.component';
import { CountryDialogComponent } from './country-dialog/country-dialog.component';
import { StateComponent } from './state/state.component';
import { StateDialogComponent } from './state-dialog/state-dialog.component';
import { DistrictComponent } from './district/district.component';
import { DistrictDialogComponent } from './district-dialog/district-dialog.component';
import { CityComponent } from './city/city.component';
import { CityDialogComponent } from './city-dialog/city-dialog.component';
import { AreaComponent } from './area/area.component';
import { AreaDialogComponent } from './area-dialog/area-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    HomeComponent,
    MasterComponent,
    CountryComponent,
    CountryDialogComponent,
    StateComponent,
    StateDialogComponent,
    DistrictComponent,
    DistrictDialogComponent,
    CityComponent,
    CityDialogComponent,
    AreaComponent,
    AreaDialogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule
  ],
  entryComponents: [
    CountryDialogComponent,
    StateDialogComponent,
    DistrictDialogComponent,
    CityDialogComponent,
    AreaDialogComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
