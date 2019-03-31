import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, ObservableLike } from 'rxjs';
import { LoginResultModel } from '../interfaces/login-result-model';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) { 
    
  }
  login(email: string, password: string): Observable<LoginResultModel> {
    var userData =
      'username=' + email + '&password=' + password + '&grant_type=password';
    var reqHeader = new HttpHeaders({
      'Content-Type': 'application/x-www-form-urlencoded',
    });

    return this.http.post<LoginResultModel>(
      'http://localhost:49864/token',
      userData,
      { headers: reqHeader },
    );
  }
}
