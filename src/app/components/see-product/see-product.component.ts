import { Categoria } from './../../interfaces/Categoria';
import { CategoriaService } from './../../services/categoria.service';
import { Produto } from './../../interfaces/Produto';
import { ProductService } from './../../services/product.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-see-product',
  templateUrl: './see-product.component.html',
  styleUrls: ['./see-product.component.css']
})
export class SeeProductComponent implements OnInit {

  id: number;
  idCategoria: number;

  produto: Produto | undefined;
  categoria: Categoria | undefined;

  constructor(private aRoute: ActivatedRoute,
              private _produtoService: ProductService,
              private _categoriaService: CategoriaService)
  {
    this.aRoute.snapshot.paramMap.get('id');
    this.id = +this.aRoute.snapshot.paramMap.get('id')!;

    this.aRoute.snapshot.paramMap.get('id');
    this.idCategoria = +this.aRoute.snapshot.paramMap.get('id')!;
  }

  ngOnInit(): void {
    this.getProduto();
    this.getCategoria();
  }

  getProduto(){
    this._produtoService.getProduto(this.id).subscribe(data => {
      this.produto = data;
    })
  }

  getCategoria(){
    this._categoriaService.getCategoria(this.idCategoria).subscribe(data => {
      this.categoria = data;
    })
  }
}
