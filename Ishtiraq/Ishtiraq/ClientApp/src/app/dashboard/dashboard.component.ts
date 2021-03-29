import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

export interface ISubscription {
  code: string;
  name: string;
  area: string;
  city: string;
  state: string;
  mobile: string;
  agent: string;
  endDate: string;
}

const ELEMENT_DATA: ISubscription[] = [
  { code: '001', name: 'Ashrafali Ansari', area: 'Juhapura', city: 'Ahmedabad', state: 'Gujarat', mobile: '9874563215', agent: 'Saeedahmed Falahi', endDate: '05/25/2020' },
  { code: '002', name: 'DanishAfzal Ansari', area: 'Tandalja', city: 'Ahmedabad', state: 'Gujarat', mobile: '9585748547', agent: 'Sadullah Khan', endDate: '05/25/2020' },
  { code: '003', name: 'Azharuddin Shaikh', area: 'Sarkhej', city: 'Ahmedabad', state: 'Gujarat', mobile: '9874568965', agent: 'Mohiyuddin Shaikh', endDate: '05/25/2020' },
  { code: '004', name: 'Sohel Sachora', area: 'Juhapura', city: 'Ahmedabad', state: 'Gujarat', mobile: '9632587410', agent: 'Sadullah Khan', endDate: '05/25/2020' },
  { code: '005', name: 'Anwarkhan Baloch', area: 'Juhapura', city: 'Ahmedabad', state: 'Gujarat', mobile: '9685742589', agent: 'Mohiyuddin Shaikh', endDate: '05/25/2020' },
  { code: '006', name: 'Saeedahmed Falahi', area: 'Kalupur', city: 'Ahmedabad', state: 'Gujarat', mobile: '9512365487', agent: 'Sadullah Khan', endDate: '05/25/2020' },
  { code: '007', name: 'Ab.Qadar Sachora', area: 'Juhapura', city: 'Ahmedabad', state: 'Gujarat', mobile: '1254785965', agent: 'Saeedahmed Falahi', endDate: '05/25/2020' },
  { code: '008', name: 'Dr.MuhammedYaqub Memon', area: 'Juhapura', city: 'Ahmedabad', state: 'Gujarat', mobile: '9635874596', agent: 'Sadullah Khan', endDate: '05/25/2020' },
  { code: '009', name: 'Ab.Razzak Shaikh', area: 'Kalupur', city: 'Ahmedabad', state: 'Gujarat', mobile: '8956231245', agent: 'Sadullah Khan', endDate: '05/25/2020' },
  { code: '010', name: 'ShakeelAhmed Rajput', area: 'Rakhiyal', city: 'Ahmedabad', state: 'Gujarat', mobile: '5467895895', agent: 'Anwer khan', endDate: '05/25/2020' },
  { code: '011', name: 'Waseefhusen Shaikh', area: 'Rakhiyal', city: 'Ahmedabad', state: 'Gujarat', mobile: '9865986598', agent: 'Sadullah Khan', endDate: '05/25/2020' },
];

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  code: string;
  name: string;
  area: string;
  city: string;
  state: string;
  mobile: string;
  agent: string;
  endDate: string;

  constructor() { }

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['code', 'name', 'area', 'city', 'state', 'mobile', 'agent', 'endDate', 'actions'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
