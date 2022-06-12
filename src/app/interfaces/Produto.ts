export interface Produto {
  id?: number;
  categoria: string;
  nome: string;
  fabricacao: Date;
  validade: Date;
  preco: number;
}
