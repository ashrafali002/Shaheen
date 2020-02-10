import { Component, OnInit } from '@angular/core';
import { LoginService } from '../shared/login.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private loginService: LoginService, private router: Router) { }

  ngOnInit() {
  }

  onCancel(event) {
    event.preventDefault();
    this.loginService.form.reset();
    this.loginService.initializeLoginForm();
  }

  onSubmit() {
    this.router.navigate(['/home']);
  }

}
