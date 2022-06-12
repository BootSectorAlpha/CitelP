import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private myAppUrl = 'https://localhost:44360/';
  private myApiUrl = 'api/produto/';

  constructor(private http: HttpClient) { }

  getlistProdutos(): Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }
}
