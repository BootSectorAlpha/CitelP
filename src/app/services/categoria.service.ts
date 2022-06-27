import { Categoria } from './../interfaces/Categoria';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private myAppUrl = 'https://localhost:44360/';
  private myApiUrl = 'api/produto/';

  constructor(private http: HttpClient) { }

  getlistCategorias(): Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }

  deleteCategoria(id: number): Observable<any> {
    return this.http.delete(this.myAppUrl + this.myApiUrl + id);
  }

  getCategoria(id: number): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApiUrl + id);
  }

  adicionar(corpoCategoria: Categoria): Observable<any> {
    return this.http.post(this.myAppUrl + this.myApiUrl, corpoCategoria);
  }

  updateCategoria(id: number, categoria: Categoria): Observable<any> {
    return this.http.put(this.myAppUrl + this.myApiUrl + id, categoria);
  }
}
