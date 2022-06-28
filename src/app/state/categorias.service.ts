import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ID } from '@datorama/akita';
import { tap } from 'rxjs/operators';
import { Categoria } from './categoria.model';
import { CategoriasStore } from './categorias.store';

@Injectable({ providedIn: 'root' })
export class CategoriasService {

  constructor(private categoriasStore: CategoriasStore, private http: HttpClient) {
  }

  async getAll() {
    const response = await this.http.get('https://localhost:44360/api/categoria/').toPromise();
    this.categoriasStore.set(response.data);
  }

  get() {
    return this.http.get<Categoria[]>('https://api.com').pipe(tap(entities => {
      this.categoriasStore.set(entities);
    }));
  }

  add(categoria: Categoria) {
    this.categoriasStore.add(categoria);
  }

  update(id: ID, categoria: Partial<Categoria>) {
    this.categoriasStore.update(id, categoria);
  }

  remove(id: ID) {
    this.categoriasStore.remove(id);
  }

}
