import { Injectable } from '@angular/core';
import { QueryEntity } from '@datorama/akita';
import { CategoriasStore, CategoriasState } from './categorias.store';

@Injectable({ providedIn: 'root' })
export class CategoriasQuery extends QueryEntity<CategoriasState> {

  constructor(protected override store: CategoriasStore) {
    super(store);
  }

}
