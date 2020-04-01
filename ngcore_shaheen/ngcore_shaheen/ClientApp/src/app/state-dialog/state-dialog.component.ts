import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { IState } from '../state/state.component';

@Component({
  selector: 'app-state-dialog',
  templateUrl: './state-dialog.component.html',
  styleUrls: ['./state-dialog.component.scss']
})
export class StateDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<StateDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: IState) { }

  ngOnInit() {
  }

  onClose() { 
    this.dialogRef.close();
  }

}
