import { Component, OnInit } from '@angular/core';
import { MasterService } from '../shared/master.service';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.scss']
})
export class MasterComponent implements OnInit {

  constructor(private masterService: MasterService) { }

  ngOnInit() {
  }

  onSubmit() {
    alert('submit button clicked');
  }

  onCancel(event) {
    event.preventDefault();
    alert('Cancel button clicked');
  }

}
