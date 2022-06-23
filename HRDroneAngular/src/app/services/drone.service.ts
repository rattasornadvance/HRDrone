import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ApiService } from './api.services';

@Injectable()
export class DroneService {
  private apiPATH = 'api/DroneTracking';

  constructor(private api: ApiService) { }

  public GetDroneAll(): Observable<any> {
    return this.api.GET(`${this.apiPATH}/GetDroneAll`);
  }
  public GetDroneTracking(RegId: number): Observable<any> {
    const creds = { regId: RegId};
    return this.api.POST(`${this.apiPATH}/GetDroneTracking`, creds);
  }

}
