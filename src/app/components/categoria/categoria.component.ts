import { CategoriasQuery } from './../../state/categorias.query';
import { CategoriasService } from './../../state/categorias.service';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { Categoria, Produto } from 'src/app/state/categoria.model';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.css']
})
export class CategoriaComponent implements OnInit
 {

  categoria$: Observable<Categoria>;
  categoriaId: string;
  selectedProduto: Produto = {} as Produto;

  constructor(private route: ActivatedRoute,
    private categoriasService: CategoriasService,
    private categoriasQuery: CategoriasQuery) { }

  ngOnInit(): void {
    this.categoriaId = this.route.snapshot.params.id;
    this.categoria$ = this.categoriasQuery.selectEntity(this.categoriaId);
  }

}
