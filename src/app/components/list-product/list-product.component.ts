import { CategoriaService } from './../../services/categoria.service';
import { Categoria } from './../../interfaces/Categoria';
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
  listaCategoria: Categoria[] = [];

  constructor(private _produtoService: ProductService,
              private _categoriaService: CategoriaService,
              private toastr: ToastrService) { }

  ngOnInit(): void {
    this.getProdutos();
    this.getCategorias();
  }

  getProdutos(){
    this._produtoService.getlistProdutos().subscribe(data => {
      this.listaProduto = data;
    }, error => {
      this.toastr.error('Ocorreu um erro!', 'Erro!');
      console.log(error);
    })
  }

  getCategorias(){
    this._categoriaService.getlistCategorias().subscribe(data => {
      this.listaCategoria = data;
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
