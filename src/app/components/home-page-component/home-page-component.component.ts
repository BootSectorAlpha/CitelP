import { CategoriasService } from './../../state/categorias.service';
import { CategoriaService } from './../../services/categoria.service';
import { CategoriasQuery } from './../../state/categorias.query';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-page-component',
  templateUrl: './home-page-component.component.html',
  styleUrls: ['./home-page-component.component.css']
})
export class HomePageComponentComponent implements OnInit
{
   categorias$ = this.categoriasQuery.selectAll();
   loading$ = this.categoriasQuery.selectLoading();

  constructor( private categoriasService: CategoriasService,
               private categoriasQuery: CategoriasQuery) { }

  ngOnInit(): void
  {
    !this.categoriasQuery.getHasCache() && this.categoriasService.get();
  }

}
