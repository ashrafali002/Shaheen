import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { ICountry } from '../country/country.component';


@Component({
  selector: 'app-country-dialog',
  templateUrl: './country-dialog.component.html',
  styleUrls: ['./country-dialog.component.scss']
})
export class CountryDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<CountryDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: ICountry) { }

  ngOnInit() {
  }

  onClose(): void {
    this.dialogRef.close();
  }
}
