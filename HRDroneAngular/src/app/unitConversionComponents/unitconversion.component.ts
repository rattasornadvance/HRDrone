import {
  Component,
  OnInit,
  OnDestroy
} from '@angular/core';
import { DatePipe } from '@angular/common';
import { Router, ActivatedRoute } from '@angular/router';
import { UnitConversionService } from '../services/unitconversion.service';
import { UnitArea } from '../models/unit/unitArea.model';
import { UnitAreaValue } from '../models/unit/unitAreaValue.model';
import { UnitDistance } from '../models/unit/unitDistance.model';
import { UnitDistanceValue } from '../models/unit/unitDistanceValue.model';
import { UnitVolume } from '../models/unit/unitVolume.model';
import { UnitVolumeValue } from '../models/unit/unitVolumeValue.model';
import { UnitSpeed } from '../models/unit/unitSpeed.model';
import { UnitSpeedValue } from '../models/unit/unitSpeedValue.model';

@Component({
  selector: 'unit-conversion',
  templateUrl: './unitconversion.component.html',
  styleUrls: ['unitconversion.component.scss']
})
export class UnitComversionComponent implements OnDestroy, OnInit {
  public isLoading = true;
  public loadingText!: string;


  public loadingTextArea!: string;
  public unitAreaArry!: UnitArea[];
  public selectedUnitArea!: String;
  public txtAreaValue!: number;
  public calAreaAcre!: number;
  public calAreaM2!: number;
  public calAreaRai!: number;
  public selectedUnitArea1!: String;
  public txtAreaValue1!: number;
  public selectedUnitArea2!: String;
  public txtAreaValue2!: number;

  public loadingTextDistance!: string;
  public unitDistanceArry!: UnitDistance[];
  public selectedUnitDistance!: String;
  public txtDistanceValue!: number;
  public calDistanceMile!: number;
  public calDistanceMetre!: number;
  public calDistanceWa!: number;
  public selectedUnitDistance1!: String;
  public txtDistanceValue1!: number;
  public selectedUnitDistance2!: String;
  public txtDistanceValue2!: number;

  public loadingTextVolume!: string;
  public unitVolumeArry!: UnitVolume[];
  public selectedUnitVolume!: String;
  public txtVolumeValue!: number;
  public calunitMl!: number;
  public calunitCm3!: number;
  public calunitFlOz!: number;
  public selectedUnitVolume1!: String;
  public txtVolumeValue1!: number;
  public selectedUnitVolume2!: String;
  public txtVolumeValue2!: number;

  public loadingTextSpeed!: string;
  public unitSpeedArry!: UnitSpeed[];
  public selectedUnitSpeed!: String;
  public txtSpeedValue!: number;
  public calunitMph!: number;
  public calunitMs!: number;
  public calunitKmh!: number;
  public selectedUnitSpeed1!: String;
  public txtSpeedValue1!: number;
  public selectedUnitSpeed2!: String;
  public txtSpeedValue2!: number;

  constructor(
    private api: UnitConversionService
  ) { }

  public ngOnInit() {
    this.preparingData();
  }
  public ngOnDestroy() {
    console.log('unit.component_ondestroy');
  }
  public btnSearchArea_click() {
    var _selectedArea = this.unitAreaArry.filter((f) => f.unitArea == this.selectedUnitArea)[0];
    this.loadingTextArea = 'Calculating...';
    this.api.ConvertAreaResult(_selectedArea.unitArea, this.txtAreaValue).subscribe((res) => {
      this.loadingTextArea = '';
      var _result = res.resultJson as UnitAreaValue;
      console.log(_result);
      this.calAreaAcre = _result.unitAcre;
      this.calAreaM2 = _result.unitM2;
      this.calAreaRai = _result.unitRai;
    });
  }
  public btnSearchDistance_click() {
    var _selectedDistance = this.unitDistanceArry.filter((f) => f.unitDistance == this.selectedUnitDistance)[0];
    this.loadingTextDistance = 'Calculating...';
    this.api.ConvertDistanceResult(_selectedDistance.unitDistance, this.txtDistanceValue).subscribe((res) => {
      this.loadingTextDistance = '';
      var _result = res.resultJson as UnitDistanceValue;
      this.calDistanceMile = _result.unitMile;
      this.calDistanceMetre = _result.unitMetre;
      this.calDistanceWa = _result.unitWa;
    });
  }
  public btnSearchVolume_click() {
    var _selected = this.unitVolumeArry.filter((f) => f.unitVolume == this.selectedUnitVolume)[0];
    this.loadingTextVolume = 'Calculating...';
    this.api.ConvertVolumeResult(_selected.unitVolume, this.txtVolumeValue).subscribe((res) => {
      this.loadingTextVolume = '';
      var _result = res.resultJson as UnitVolumeValue;
      console.log(_result);
      this.calunitCm3 = _result.unitCm3;
      this.calunitFlOz = _result.unitFlOz;
      this.calunitMl = _result.unitML;
    });
  }
  public btnSearchSpeed_click() {
    var _selected = this.unitSpeedArry.filter((f) => f.unitSpeed == this.selectedUnitSpeed)[0];
    this.loadingTextSpeed = 'Calculating...';
    this.api.ConvertSpeedResult(_selected.unitSpeed, this.txtSpeedValue).subscribe((res) => {
      this.loadingTextSpeed = '';
      var _result = res.resultJson as UnitSpeedValue;
      console.log(_result);
      this.calunitMph = _result.unitMph;
      this.calunitMs = _result.unitMs;
      this.calunitKmh = _result.unitKmh;
    });
  }
  public cmbArea_onChange() {
    var _selectedArea = this.unitAreaArry.filter((f) => f.unitArea == this.selectedUnitArea1)[0];
    var _selectedAreaConvert = this.unitAreaArry.filter((f) => f.unitArea == this.selectedUnitArea2)[0];

    this.api.ConvertArea(_selectedArea.unitArea, this.txtAreaValue1, _selectedAreaConvert.unitArea).subscribe((res) => {
      this.txtAreaValue2 = res.resultJson;
      console.log(res);
    });

  }
  public cmbDistance_onChange() {
    var _selectedDistance = this.unitDistanceArry.filter((f) => f.unitDistance == this.selectedUnitDistance1)[0];
    var _selectedDistanceConvert = this.unitDistanceArry.filter((f) => f.unitDistance == this.selectedUnitDistance2)[0];

    this.api.ConvertDistance(_selectedDistance.unitDistance, this.txtDistanceValue1, _selectedDistanceConvert.unitDistance).subscribe((res) => {
      this.txtDistanceValue2 = res.resultJson;
      console.log(res);
    });
  }
  public cmbVolume_onChange() {
    var _selectedVolume = this.unitVolumeArry.filter((f) => f.unitVolume == this.selectedUnitVolume1)[0];
    var _selectedVolumeConvert = this.unitVolumeArry.filter((f) => f.unitVolume == this.selectedUnitVolume2)[0];

    this.api.ConvertVolume(_selectedVolume.unitVolume, this.txtVolumeValue1, _selectedVolumeConvert.unitVolume).subscribe((res) => {
      this.txtVolumeValue2 = res.resultJson;
      console.log(res);
    });
  }
  public cmbSpeed_onChange() {
    var _selectedSpeed = this.unitSpeedArry.filter((f) => f.unitSpeed == this.selectedUnitSpeed1)[0];
    var _selectedSpeedConvert = this.unitSpeedArry.filter((f) => f.unitSpeed == this.selectedUnitSpeed2)[0];

    this.api.ConvertSpeed(_selectedSpeed.unitSpeed, this.txtSpeedValue1, _selectedSpeedConvert.unitSpeed).subscribe((res) => {
      this.txtSpeedValue2 = res.resultJson;
      console.log(res);
    });
  }
  private preparingData() {

    this.api.GetUnitArea().subscribe((res) => {
      this.unitAreaArry = res as UnitArea[];
      this.selectedUnitArea = this.unitAreaArry[0].unitArea;
      this.selectedUnitArea1 = this.unitAreaArry[0].unitArea;
      this.selectedUnitArea2 = this.unitAreaArry[0].unitArea;
      this.api.GetUnitDistance().subscribe((res) => {
        this.unitDistanceArry = res as UnitDistance[];
        this.selectedUnitDistance = this.unitDistanceArry[0].unitDistance;
        this.selectedUnitDistance1 = this.unitDistanceArry[0].unitDistance;
        this.selectedUnitDistance2 = this.unitDistanceArry[0].unitDistance;
        this.api.GetUnitValume().subscribe((res) => {
          this.unitVolumeArry = res as UnitVolume[];
          this.selectedUnitVolume = this.unitVolumeArry[0].unitVolume;
          this.selectedUnitVolume1 = this.unitVolumeArry[0].unitVolume;
          this.selectedUnitVolume2 = this.unitVolumeArry[0].unitVolume;
          this.api.GetUnitSpeed().subscribe((res) => {
            this.unitSpeedArry = res as UnitSpeed[];
            this.selectedUnitSpeed = this.unitSpeedArry[0].unitSpeed;
            this.selectedUnitSpeed1 = this.unitSpeedArry[0].unitSpeed;
            this.selectedUnitSpeed2 = this.unitSpeedArry[0].unitSpeed;
            this.isLoading = false;
          });
        });
      });
    });

  }

}
