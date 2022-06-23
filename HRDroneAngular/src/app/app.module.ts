import { NgModule } from '@angular/core';
import { DatePipe } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, PreloadAllModules } from '@angular/router';

import { AppComponent } from './app.component';
import { ROUTES } from './app.routes';
import { DroneDashboardComponent } from './droneComponents/dashboard/dronedashboard.component';
import { UnitComversionComponent } from './unitConversionComponents/unitconversion.component';
import { DroneService } from './services/drone.service';
import { UnitConversionService } from './services/unitconversion.service';
import { ApiService } from './services/api.services';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    DroneDashboardComponent,
    UnitComversionComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(ROUTES, { useHash: true, preloadingStrategy: PreloadAllModules }),
  ],
  providers: [
    DatePipe,
    ApiService,
    DroneService,
    UnitConversionService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
