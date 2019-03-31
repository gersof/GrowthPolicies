import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LocaldataService {

  setToken(
    token: string,
    expires_in: string,
    token_type: string,
    username: string,
    userId: string,
    userRole: string,
  ): void {
    localStorage.setItem('TOKEN', token);
    localStorage.setItem('USER', username);
    localStorage.setItem('EXPIRES_IN', expires_in);
    localStorage.setItem('TOKEN_TYPE', token_type);
    localStorage.setItem('ID', userId);
    localStorage.setItem('USERROLES', userRole);
  }

  isLogged() {
    return this.getToken() != null;
  }

  public getToken() {
    return localStorage.getItem('TOKEN');
  }

  public getName() {
    return localStorage.getItem('USER');
  }

  public getUserId() {
    return localStorage.getItem('ID');
  }

  public getRoles() {
    return localStorage.getItem('USERROLES');
  }

  public getPhoto() {
    return localStorage.getItem('PHOTO');
  }

  public getId() {
    return localStorage.getItem('ID');
  }
}
