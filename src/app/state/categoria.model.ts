import { DeclarationListEmitMode } from "@angular/compiler";
import { ID } from '@datorama/akita';

export interface Categoria {
  id: number;
  nome: string;
  produto: Produto[];
}

export interface Produto {
  id: number;
  nome: string;
  fabricacao: Date;
  validade: Date;
  preco: number;
}



// export function createCategoria(params: Partial<Categoria>) {
//   return {

//   } as Categoria;
// }
