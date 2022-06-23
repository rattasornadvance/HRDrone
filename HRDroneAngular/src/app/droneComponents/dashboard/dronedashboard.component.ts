import {
  Component,
  OnInit,
  OnDestroy
} from '@angular/core';
import { DroneRegistration } from 'src/app/models/drone/droneRegistration.model';
import { DroneService } from 'src/app/services/drone.service';

@Component({
  selector: 'drone-dashboard',
  templateUrl: './dronedashboard.component.html',
  styleUrls: ['dronedashboard.component.scss']
})
export class DroneDashboardComponent implements OnDestroy, OnInit {
  public isLoading = true;
  public loadingText!: string;

  public droneName!: string;
  public selectedDroneId!: number;
  public droneArry!: DroneRegistration[];

  public height!: string;
  public batteryLv!: string;
  public speed!: string;
  public latitude!: string;
  public longitude!: string;

  constructor(
    private api: DroneService
  ) { }

  public ngOnInit() {
    this.preparingData();
  }
  public ngOnDestroy() {
    console.log('drone.component_ondestroy');
  }
  public cmbDrone_onChange() {
    var _droneSelect = this.droneArry.filter(f => f.regId == this.selectedDroneId)[0];
    this.droneName = _droneSelect.droneName;
    this.isLoading = true;
    this.api.GetDroneTracking(_droneSelect.regId).subscribe((res) => {
      console.log(res);
      if(res.code == 200){
        this.height = res.resultJson.height;
        this.latitude = res.resultJson.latitude;
        this.longitude = res.resultJson.longittude;
        this.speed = res.resultJson.speed;
        this.batteryLv = res.resultJson.batterLv;
      }
      this.isLoading = false;
    });
  }

  private preparingData() {
    this.api.GetDroneAll().subscribe((res) => {
      this.droneArry = res;
      this.isLoading = false;
    });
  }
}
