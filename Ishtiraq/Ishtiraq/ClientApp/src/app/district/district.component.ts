import { Component, OnInit } from '@angular/core';
import { MatTableDataSource, MatDialog } from '@angular/material';
import { DistrictDialogComponent } from '../district-dialog/district-dialog.component';

export interface IDistrict {
  districtId: number;
  districtName: string;
  stateName: string;
}

const ELEMENT_DATA: IDistrict[] = [
  { districtId: 1, districtName: 'Ahmedabad', stateName: 'Gujarat' },
  { districtId: 2, districtName: 'Saberkantha', stateName: 'Gujarat' },
  { districtId: 3, districtName: 'Aravalli', stateName: 'Gujarat' },
  { districtId: 4, districtName: 'Anand', stateName: 'Gujarat' },
  { districtId: 5, districtName: 'Kheda', stateName: 'Gujarat' },
  { districtId: 6, districtName: 'Panchmahal', stateName: 'Gujarat' },
  { districtId: 7, districtName: 'Amreli', stateName: 'Gujarat' },
  { districtId: 8, districtName: 'Jamnagar', stateName: 'Gujarat' },
  { districtId: 9, districtName: 'Junagadh', stateName: 'Gujarat' },
  { districtId: 10, districtName: 'Bhavnagar', stateName: 'Gujarat' },
];

@Component({
  selector: 'app-district',
  templateUrl: './district.component.html',
  styleUrls: ['./district.component.scss']
})
export class DistrictComponent implements OnInit {

  districtId: number;
  districtName: string;
  stateName: string;

  constructor(private dialog: MatDialog) { }

  ngOnInit() {
  }

  displayedColumns: string[] = ['districtId', 'districtName', 'stateName', 'actions'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  openDistrictDialog() {
    const dialogRef = this.dialog.open(DistrictDialogComponent, {
      width: '500px',
      disableClose: true,
      data: { districtId: this.districtId, districtName: this.districtName, stateName: this.stateName }
    });

    dialogRef.afterClosed().subscribe(result => {
      this.districtName = result;
    });
  }
}
