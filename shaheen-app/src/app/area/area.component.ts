import { Component, OnInit } from '@angular/core';
import { MatDialog, MatTableDataSource } from '@angular/material';
import { AreaDialogComponent } from '../area-dialog/area-dialog.component';

export interface IArea {
  areaId: number;
  areaName: string;
  cityName: string;
}

const ELEMENT_DATA: IArea[] = [
  { areaId: 1, areaName: 'Jamalpur', cityName: 'Ahmedabad' },
  { areaId: 2, areaName: 'Kalupur', cityName: 'Ahmedabad' },
  { areaId: 3, areaName: 'Juhapura', cityName: 'Ahmedabad' },
  { areaId: 4, areaName: 'Paldi', cityName: 'Ahmedabad' },
  { areaId: 5, areaName: 'Vastrapur', cityName: 'Ahmedabad' },
  { areaId: 6, areaName: 'Sarkhej', cityName: 'Ahmedabad' },
  { areaId: 7, areaName: 'Dariyapur', cityName: 'Ahmedabad' },
  { areaId: 8, areaName: 'Shahpur', cityName: 'Ahmedabad' },
];

@Component({
  selector: 'app-area',
  templateUrl: './area.component.html',
  styleUrls: ['./area.component.scss']
})
export class AreaComponent implements OnInit {

  areaId: number;
  areaName: string;
  cityName: string;


  constructor(private dialog: MatDialog) { }

  ngOnInit() {
  }

  displayedColumns: string[] = ['areaId', 'areaName', 'cityName', 'actions'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  openAreaDialog() {
    const dialogRef = this.dialog.open(AreaDialogComponent, {
      width: '500px',
      disableClose: true,
      data: { areaId: this.areaId, areaName: this.areaName, cityName: this.cityName }
    });

    dialogRef.afterClosed().subscribe(result => {
      this.areaName = result;
    });
  }

}
