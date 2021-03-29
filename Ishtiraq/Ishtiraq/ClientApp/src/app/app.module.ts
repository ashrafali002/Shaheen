import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { MaterialModule } from './material/material.module';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MasterComponent } from './master/master.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AreaComponent } from './area/area.component';
import { AreaDialogComponent } from './area-dialog/area-dialog.component';
import { CityComponent } from './city/city.component';
import { CityDialogComponent } from './city-dialog/city-dialog.component';
import { CountryComponent } from './country/country.component';
import { CountryDialogComponent } from './country-dialog/country-dialog.component';
import { DistrictComponent } from './district/district.component';
import { DistrictDialogComponent } from './district-dialog/district-dialog.component';
import { StateDialogComponent } from './state-dialog/state-dialog.component';
import { StateComponent } from './state/state.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    DashboardComponent,
    MasterComponent,
    AreaComponent,
    AreaDialogComponent,
    CityComponent,
    CityDialogComponent,
    CountryComponent,
    CountryDialogComponent,
    DistrictComponent,
    DistrictDialogComponent,
    StateDialogComponent,
    StateComponent
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
