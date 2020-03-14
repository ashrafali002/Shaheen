import { Component, OnInit } from '@angular/core';
import { MatTableDataSource, MatDialog } from '@angular/material';
import { CityDialogComponent } from '../city-dialog/city-dialog.component';

export interface ICity {
  cityId: number;
  cityName: string;
  districtName: string;
}

const ELEMENT_DATA: ICity[] = [
  { cityId: 1, cityName: 'Ahmedabad', districtName: 'Ahmedabad' },
  { cityId: 2, cityName: 'Dholka', districtName: 'Ahmedabad' },
  { cityId: 3, cityName: 'Vadodara', districtName: 'Vadodara' },
  { cityId: 4, cityName: 'Himmatnagar', districtName: 'Saberkantha' },
  { cityId: 5, cityName: 'Modasa', districtName: 'Aravalli' },
  { cityId: 6, cityName: 'Dhansura', districtName: 'Aravalli' },
  { cityId: 7, cityName: 'Bhavnagar', districtName: 'Bhavnagar' },
  { cityId: 8, cityName: 'Godhra', districtName: 'Panchmahal' },
];

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.scss']
})
export class CityComponent implements OnInit {

  cityId: number;
  cityName: string;
  districtName: string;

  constructor(private dialog: MatDialog) { }

  ngOnInit() {
  }

  displayedColumns: string[] = ['cityId', 'cityName', 'districtName', 'actions'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  openCityDialog() {
    const dialogRef = this.dialog.open(CityDialogComponent, {
      width: '500px',
      data: { cityId: this.cityId, cityName: this.cityName, districtName: this.districtName }
    });

    dialogRef.afterClosed().subscribe(result => {
      this.districtName = result;
    });
  }
}
