import { Product } from '../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {

  listaProduto: Product[] = [
    { categoria: 'info', nome: 'mouse', fabricacao: new Date(), validade: new Date(), preco: 15.90},
    { categoria: 'info', nome: 'impressora', fabricacao: new Date(), validade: new Date(), preco: 16.90}
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
