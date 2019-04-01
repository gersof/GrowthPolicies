import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsersService } from 'src/app/services/users.service';
import { Router } from '@angular/router';
import { LocaldataService } from 'src/app/services/localdata.service';
import { NzNotificationService } from 'ng-zorro-antd';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [UsersService]
})
export class LoginComponent implements OnInit {
  validateForm: FormGroup;

  submitForm(): void {
    for (const i in this.validateForm.controls) {
      this.validateForm.controls[i].markAsDirty();
      this.validateForm.controls[i].updateValueAndValidity();
    }
  }

  constructor(private fb: FormBuilder, private _localdata:LocaldataService, private _userserv: UsersService, private router: Router,    private notification: NzNotificationService
    ) { }

  ngOnInit(): void {
    this.validateForm = this.fb.group({
      userName: [null, [Validators.required]],
      password: [null, [Validators.required]],
      remember: [true]
    });
  }

  tryLogin() {
    this._userserv.login(this.validateForm.controls['userName'].value, this.validateForm.controls['password'].value).subscribe(
      r => {
        if (r.roles.includes('admin')) {
          r.roles = 'admin';
        } else {
          r.roles = 'client';
        }

        if (r.access_token) {
          this._localdata.setToken(
            r.access_token,
            String(r.expires_in),
            r.token_type,
            r.userName,
            r.userId,
            r.roles,
          );
          const urlDestArr = this.router.url.split('=');
          let urlDest = r.roles;
          if (urlDestArr.length > 1) {
            urlDest = urlDestArr[1].replace(/%2F/gi, '/');
          }
          this.router.navigateByUrl("/dashboard/clients");
        }
      },
      r => {
        this.notification.create(
          'error',
          'Error!',
          'The user and/or password are invalid!'
        );
      },
    );
  }
}
