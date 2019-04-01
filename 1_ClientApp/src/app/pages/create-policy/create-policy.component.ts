import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { PolicyModel } from 'src/app/models/Policy.model';
import { ActivatedRoute } from '@angular/router';
import { LocaldataService } from 'src/app/services/localdata.service';
import { PolicesService } from 'src/app/services/polices.service';
// import getISOWeek from 'date-fns/get_iso_week';
import { en_US, zh_CN, NzI18nService } from 'ng-zorro-antd';
import { NzNotificationService } from 'ng-zorro-antd';


@Component({
  selector: 'app-create-policy',
  templateUrl: './create-policy.component.html',
  styleUrls: ['./create-policy.component.css']
})
export class CreatePolicyComponent implements OnInit {
  public policyId: String;
  policy = new PolicyModel(0, '', '', '', '', '', '', '');
  coverages: any[];
  allcoverages: any[];
  risks: any[];
  closeResult: string;
  alertRisk: boolean;

  constructor(
    private route: ActivatedRoute,
    private _localData: LocaldataService,
    private _policy: PolicesService,
    private notification: NzNotificationService
  ) { }
  ngOnInit(): void {
    this.loadCoverages();
    this.loadRisks();
    if (this.policyId) this.loadPolicy();
  }

  loadPolicy() {
    this._policy
      .getObjectsList('Policies/' + this.policyId, this._localData.getToken())
      .subscribe(
        result => {
          if (result) {
            this.policy = result;
          } else {
            alert('error API');
          }
        },
        error => {
          alert('error');
        },
      );
  }

  loadCoverages() {
    this._policy
      .getObjectsList('Coverages', this._localData.getToken())
      .subscribe(
        result => {
          if (result) {
            this.coverages = result;
            this.allcoverages = result;
          } else {
            alert('error api');
          }
        },
        error => {
          alert('error ');

        },
      );
  }

  loadRisks() {
    this._policy.getObjectsList('Risks', this._localData.getToken()).subscribe(
      result => {
        if (result) {
          this.risks = result;
        } else {
          alert('error api');
        }
      },
      error => {
        alert('error ');

      });
  }

  savePolicy() {
    if (this.policyId) {
      this.editPolicy();
    } else {
      this.addPolicy();
    }
  }

  editPolicy() {
    this._policy
    .updatePolicy('Policies', this._localData.getToken(), this.policy)
    .subscribe(
      result => {
        if (result === 'ok') {
          this.notification.create(
            'success',
            'Success!',
            'Policy was saved'
          );
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

  addPolicy() {
    this._policy
      .savePolicy('Policies', this._localData.getToken(), this.policy)
      .subscribe(
        result => {
          if (result === 'ok') {
            this.notification.create(
              'success',
              'Success!',
              'Policy was saved'
            );
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

  onChangeRisk(risk) {
    if (risk === 4) {
      this.notification.create(
        'warning',
        'Attention!',
        'High Policy Risk! Please, select a policy coverage under 50%.'
      );
    }
  }

}

