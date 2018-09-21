import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './components/index/index.component';
import { MonitoringService } from './services/monitoring.service';

const routes: Routes = [
	{ path: "", component: IndexComponent }
]

@NgModule({
  imports: [
	RouterModule.forRoot(routes),
    CommonModule
  ],
  declarations: [IndexComponent],
  providers: [MonitoringService]
})
export class MonitoringModule { }
