import { Produto } from './../interfaces/Produto';
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

  deleteProduto(id: number): Observable<any> {
    return this.http.delete(this.myAppUrl + this.myApiUrl + id);
  }

  getProduto(id: number): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApiUrl + id);
  }

  // salvarProduto(corpoProduto: Produto): Observable<any>
  adicionar(corpoProduto: Produto): Observable<any> {
    return this.http.post(this.myAppUrl + this.myApiUrl, corpoProduto);
  }
}
