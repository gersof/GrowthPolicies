import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { LocaldataService } from 'src/app/services/localdata.service';
import { UsersService } from 'src/app/services/users.service';
import { Router } from '@angular/router';
import { NzNotificationService } from 'ng-zorro-antd';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {
  validateForm: FormGroup;

  constructor(private fb: FormBuilder, private _localdata:LocaldataService, private _userserv: UsersService, private router: Router,private notification: NzNotificationService) { }
  confirmationValidator = (control: FormControl): { [s: string]: boolean } => {
    if (!control.value) {
      return { required: true };
    } else if (control.value !== this.validateForm.controls.password.value) {
      return { confirm: true, error: true };
    }
    return {};
  };

  updateConfirmValidator(): void {
    /** wait for refresh value */
    Promise.resolve().then(() => this.validateForm.controls.checkPassword.updateValueAndValidity());
  }

  ngOnInit(): void {
    this.validateForm = this.fb.group({
      email: [null, [Validators.email, Validators.required]],
      password: [null, [Validators.required]],
      checkPassword: [null, [Validators.required, this.confirmationValidator]],    
    });
  }

  submitForm(): void {
    for (const i in this.validateForm.controls) {
      this.validateForm.controls[i].markAsDirty();
      this.validateForm.controls[i].updateValueAndValidity();
    }
    if(this.validateForm.valid){
      this.registerUser()
    }
  }

  registerUser(){
    this._userserv.register(this.validateForm.controls['email'].value, this.validateForm.controls['password'].value,this.validateForm.controls['checkPassword'].value).subscribe(
      result => {
        this.notification.create(
          'success',
          'Success!',
          'The User was created!'
        );
      },
      error => {
        this.notification.create(
          'error',
          'error!',
          'An error ocurred creating the user!'
        );
      },
    );
  }

}
