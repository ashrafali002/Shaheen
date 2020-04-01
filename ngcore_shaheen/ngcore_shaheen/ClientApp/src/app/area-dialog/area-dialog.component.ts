import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { IArea } from '../area/area.component';

@Component({
  selector: 'app-area-dialog',
  templateUrl: './area-dialog.component.html',
  styleUrls: ['./area-dialog.component.scss']
})
export class AreaDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<AreaDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: IArea) { }

  ngOnInit() {
  }

  onClose() {
    this.dialogRef.close();
  }

}
