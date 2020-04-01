import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { IDistrict } from '../district/district.component';

@Component({
  selector: 'app-district-dialog',
  templateUrl: './district-dialog.component.html',
  styleUrls: ['./district-dialog.component.scss']
})
export class DistrictDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<DistrictDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: IDistrict) { }

  ngOnInit() {
  }

  onClose() {
    this.dialogRef.close();
  }

}
