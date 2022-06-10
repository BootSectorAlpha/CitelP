import { Product } from '../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {

  listaProduto: Product[] = [
    { categoria: 'info', marca: 'positivo', fabricacao: new Date(), validade: new Date(), preco: 15.90},
    { categoria: 'info', marca: 'huawei', fabricacao: new Date(), validade: new Date(), preco: 16.90}
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
