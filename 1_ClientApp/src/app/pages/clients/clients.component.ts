import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LocaldataService } from 'src/app/services/localdata.service';
import { PolicesService } from 'src/app/services/polices.service';
import { NzNotificationService } from 'ng-zorro-antd';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})
export class ClientsComponent implements OnInit {
  listOfData: any[] = [];
  constructor(private route: ActivatedRoute,
    private _localData: LocaldataService,
    private _policy: PolicesService,
    private notification: NzNotificationService) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this._policy
      .getObjectsList('users', this._localData.getToken())
      .subscribe(
        result => {
          if (result) {
            this.listOfData = result;
          } else {
            this.notification.create(
              'error',
              'Error!',
              'Error, please try later!'
            );
          }
        },
        error => {
          this.notification.create(
            'error',
            'Error!',
            'Error, please try later!'
          );
        },
      );
  }

  onDeleteConfirmUser(event) {
    if (window.confirm('Are you sure you want to delete this user?')) {
      this.onDeleteClient(event);
    } else {
      event.confirm.reject();
    }
  }

  onDeleteClient(event) {
    const userId = event.Id;
    this._policy
      .deleteClient('users/' + userId, this._localData.getToken())
      .subscribe(
        result => {
          if (result === 'ok') {
            this.notification.create(
              'success',
              'Success!',
              'The User was deleted!'
            );
  
            this.getUsers();
          } else {
            this.notification.create(
              'error',
              'Error!',
              'Error, please try later!'
            );
          }
        },
        error => {
          this.notification.create(
            'error',
            'Error!',
            'Error, please try later!'
          );
        },
      );
  }
}
