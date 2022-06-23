import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ApiService } from './api.services';

@Injectable()
export class UnitConversionService {
  private apiPATH = 'api/UnitConvert';

  constructor(private api: ApiService) { }

  public GetUnitArea(): Observable<any> {
    return this.api.GET(`${this.apiPATH}/GetUnitArea`);
  }
  public GetUnitDistance(): Observable<any> {
    return this.api.GET(`${this.apiPATH}/GetUnitDistance`);
  }
  public GetUnitValume(): Observable<any> {
    return this.api.GET(`${this.apiPATH}/GetUnitValume`);
  }
  public GetUnitSpeed(): Observable<any> {
    return this.api.GET(`${this.apiPATH}/GetUnitSpeed`);
  }
  public ConvertArea(UnitArea: string, UnitValue: number, UnitAreaConvert: string): Observable<any> {
    const creds = { unitArea: UnitArea, unitValue: UnitValue, unitAreaConvert: UnitAreaConvert };
    return this.api.POST(`${this.apiPATH}/ConvertArea`, creds);
  }
  public ConvertAreaResult(UnitArea: string, UnitValue: number): Observable<any> {
    const creds = { unitArea: UnitArea, unitValue: UnitValue };
    return this.api.POST(`${this.apiPATH}/ConvertAreaResult`, creds);
  }
  public ConvertDistance(UnitDistance: string, UnitValue: number, UnitDistanceConvert: string): Observable<any> {
    const creds = { unitDistance: UnitDistance, unitValue: UnitValue, unitDistanceConvert: UnitDistanceConvert };
    return this.api.POST(`${this.apiPATH}/ConvertDistance`, creds);
  }
  public ConvertDistanceResult(UnitDistance: string, UnitValue: number): Observable<any> {
    const creds = { unitDistance: UnitDistance, unitValue: UnitValue };
    return this.api.POST(`${this.apiPATH}/ConvertDistanceResult`, creds);
  }
  public ConvertVolume(UnitVolume: string, UnitValue: number, UnitVolumeConvert: string): Observable<any> {
    const creds = { unitVolume: UnitVolume, unitValue: UnitValue, unitVolumeConvert: UnitVolumeConvert };
    return this.api.POST(`${this.apiPATH}/ConvertVolume`, creds);
  }
  public ConvertVolumeResult(UnitVolume: string, UnitValue: number): Observable<any> {
    const creds = { unitVolume: UnitVolume, unitValue: UnitValue };
    return this.api.POST(`${this.apiPATH}/ConvertVolumeResult`, creds);
  }
  public ConvertSpeed(UnitSpeed: string, UnitValue: number, UnitSpeedConvert: string): Observable<any> {
    const creds = { unitSpeed: UnitSpeed, unitValue: UnitValue, unitSpeedConvert: UnitSpeedConvert };
    return this.api.POST(`${this.apiPATH}/ConvertSpeed`, creds);
  }
  public ConvertSpeedResult(UnitSpeed: string, UnitValue: number): Observable<any> {
    const creds = { unitSpeed: UnitSpeed, unitValue: UnitValue };
    return this.api.POST(`${this.apiPATH}/ConvertSpeedResult`, creds);
  }
}
