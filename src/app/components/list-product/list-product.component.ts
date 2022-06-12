import { ProductService } from './../../services/product.service';
import { Produto } from '../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {

  listaProduto: Produto[] = [];

  constructor(private _produtoService: ProductService,
              private toastr: ToastrService) { }

  ngOnInit(): void {
    this.getProdutos();
  }

  getProdutos(){
    this._produtoService.getlistProdutos().subscribe(data => {
      this.listaProduto = data;
    }, error => {
      this.toastr.error('Ocorreu um erro!', 'Erro!');
      console.log(error);
    })
  }

  excluirProduto(id: any){
    console.log(id);
    this._produtoService.deleteProduto(id).subscribe(data => {
      this.getProdutos();
      this.toastr.error('O Produto foi Excluído com Sucesso!', 'Registro Excluído!');
    }, error => {
      this.toastr.error('Ocorreu um erro!', 'Erro!');
      console.log(error);
    })
  }

}
