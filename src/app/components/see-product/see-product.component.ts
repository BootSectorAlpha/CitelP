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
  produto: any;

  constructor(private aRoute: ActivatedRoute,
              private _produtoService: ProductService) {
    this.aRoute.snapshot.paramMap.get('id');
    this.id = +this.aRoute.snapshot.paramMap.get('id')!;
  }

  ngOnInit(): void {
    this.getProduto();
  }

  getProduto(){
    this._produtoService.getProduto(this.id).subscribe(data => {
      this.produto = data;
    })
  }

}
