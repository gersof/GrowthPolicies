import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { PagesRoutingModule } from './simple-pages-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgZorroAntdModule, NZ_I18N, en_US } from 'ng-zorro-antd';
import { registerLocaleData } from '@angular/common';
import en from '@angular/common/locales/en';
import { CommonModule } from '@angular/common';

registerLocaleData(en);



@NgModule({
    declarations: [
        LoginComponent,
        //  RegisterComponent
    ],
    imports: [
        PagesRoutingModule,
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        NgZorroAntdModule
    ],
    providers: [{ provide: NZ_I18N, useValue: en_US }],

})
export class SimplePagesModule { }
