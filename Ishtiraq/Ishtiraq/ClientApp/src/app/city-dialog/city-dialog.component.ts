import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { ICity } from '../city/city.component';

@Component({
  selector: 'app-city-dialog',
  templateUrl: './city-dialog.component.html',
  styleUrls: ['./city-dialog.component.scss']
})

export class CityDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<CityDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: ICity) { }

  ngOnInit() {
  }

  onClose() {
    this.dialogRef.close();
  }

}
