import { ProductService } from './../../services/product.service';
import { Product } from '../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {

  listaProduto: Product[] = [];

  constructor(private _produtoService: ProductService) { }

  ngOnInit(): void {
    this.getProdutos();
  }

  getProdutos(){
    this._produtoService.getlistProdutos().subscribe(data => {
      this.listaProduto = data;
    }, error => {
      console.log(error);
    })
  }

  excluirProduto(id: any){
    console.log(id);
    this._produtoService.deleteProduto(id).subscribe(data => {
      this.getProdutos();
    }, error => {
      console.log(error);
    })
  }

}
