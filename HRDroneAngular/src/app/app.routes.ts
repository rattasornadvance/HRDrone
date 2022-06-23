import { Routes } from '@angular/router';
import { DroneDashboardComponent } from './droneComponents/dashboard/dronedashboard.component';
import { UnitComversionComponent } from './unitConversionComponents/unitconversion.component';

export const ROUTES: Routes = [
  { path: '', component: DroneDashboardComponent },
  { path: 'unitconversion', component: UnitComversionComponent },
  { path: 'drone', component: DroneDashboardComponent },
];
