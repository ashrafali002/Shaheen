import { Component, OnInit } from '@angular/core';
import { MatTableDataSource, MatDialog } from '@angular/material';
import { CountryDialogComponent } from '../country-dialog/country-dialog.component';

export interface ICountry {
  countryName: string;
  countryId: number;
}

const ELEMENT_DATA: ICountry[] = [
  { countryId: 1, countryName: 'India' },
  { countryId: 2, countryName: 'Dubai' },
  { countryId: 3, countryName: 'Abu Dhabi' },
  { countryId: 4, countryName: 'China' },
  { countryId: 5, countryName: 'Albania' },
  { countryId: 6, countryName: 'Australia' },
  { countryId: 7, countryName: 'Belgium' },
  { countryId: 8, countryName: 'Bhutan' },
  { countryId: 9, countryName: 'Brazil' },
  { countryId: 10, countryName: 'Canada' },
];

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss']
})
export class CountryComponent implements OnInit {

  countryId: number;
  countryName: string;

  constructor(public dialog: MatDialog) { }

  ngOnInit() {
  }

  displayedColumns: string[] = ['countryId', 'countryName', 'actions'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  openCountryDialog() {
    const dialogRef = this.dialog.open(CountryDialogComponent, {
      width: '500px',
      data: { countryId: this.countryId, countryName: this.countryName }
    });

    dialogRef.afterClosed().subscribe(result => {
      this.countryName = result;
    })
  }

}
