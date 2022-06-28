import { Injectable } from '@angular/core';
import { EntityState, EntityStore, StoreConfig } from '@datorama/akita';
import { Categoria } from './categoria.model';

export interface CategoriasState extends EntityState<Categoria> {}

@Injectable({ providedIn: 'root' })
@StoreConfig({ name: 'categorias' })
export class CategoriasStore extends EntityStore<CategoriasState> {

  constructor() {
    super();
  }

}
