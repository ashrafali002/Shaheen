import { Injectable } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class MasterService {

  constructor() { }

  countryForm: FormGroup = new FormGroup({
    $key: new FormControl(null),
    countryName: new FormControl()
  });
}
