import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MainMenuComponent } from './components/main-menu/main-menu.component';
import { MenuItemComponent } from './components/menu-item/menu-item.component';
import { MainComponent } from './components/main/main.component';
import { MonitoringModule } from './modules/monitoring/monitoring.module';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppRoutingModule } from './app-routing.module';


@NgModule({
  declarations: [
    AppComponent,
    MainMenuComponent,
    MenuItemComponent,
    MainComponent,
    DashboardComponent
  ],
  imports: [
	AppRoutingModule,
	BrowserModule,
	MonitoringModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
