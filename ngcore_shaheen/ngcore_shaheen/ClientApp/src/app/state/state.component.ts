import { Component, OnInit } from '@angular/core';
import { MatDialog, MatTableDataSource } from '@angular/material';
import { StateDialogComponent } from '../state-dialog/state-dialog.component';

export interface IState {
  stateId: number;
  stateName: string;
  countryName: string;
}

const ELEMENT_DATA: IState[] = [
  { stateId: 1, stateName: 'Gujarat', countryName: 'India' },
  { stateId: 2, stateName: 'Maharashtra', countryName: 'India' },
  { stateId: 3, stateName: 'Rajasthan', countryName: 'India' },
  { stateId: 4, stateName: 'Bihar', countryName: 'India' },
  { stateId: 5, stateName: 'Karnataka', countryName: 'India' },
  { stateId: 6, stateName: 'Andhra Pradesh', countryName: 'India' },
  { stateId: 7, stateName: 'Kerala', countryName: 'India' },
];

@Component({
  selector: 'app-state',
  templateUrl: './state.component.html',
  styleUrls: ['./state.component.scss']
})
export class StateComponent implements OnInit {

  stateId: number;
  stateName: string;
  countryName: string;

  constructor(public dialog: MatDialog) { }

  ngOnInit() {
  }

  displayedColumns: string[] = ['stateId', 'stateName', 'countryName', 'actions'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  openStateDialog() {
    const dialogRef = this.dialog.open(StateDialogComponent, {
      width: '500px',
      disableClose: true,
      data: { stateId: this.stateId, stateName: this.stateName, countryName: this.countryName }
    });

    dialogRef.afterClosed().subscribe(result => {
      this.stateName = result;
    });
  }

}
