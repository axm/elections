import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MainMenuComponent } from './components/main-menu/main-menu.component';
import { MenuItemComponent } from './components/menu-item/menu-item.component';
import { MainComponent } from './components/main/main.component';
import { MonitoringModule } from './modules/monitoring/monitoring.module';

const routes: Routes = [

]

@NgModule({
  declarations: [
    AppComponent,
    MainMenuComponent,
    MenuItemComponent,
    MainComponent
  ],
  imports: [
	RouterModule.forRoot(routes),
	BrowserModule,
	MonitoringModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
