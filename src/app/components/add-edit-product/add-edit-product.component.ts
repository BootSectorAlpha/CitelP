import { ProductService } from './../../services/product.service';
import { Produto } from './../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-edit-product',
  templateUrl: './add-edit-product.component.html',
  styleUrls: ['./add-edit-product.component.css']
})
export class AddEditProductComponent implements OnInit {

  adicionarProduto: FormGroup;

  constructor(private fb: FormBuilder,
              private _produtoService: ProductService,
              private router: Router) {
    this.adicionarProduto = this.fb.group({
      // categoria: ['', Validators.required],
      // nome: ['', Validators.required],
      // fabricacao: ['', Validators.required],
      // validade: ['', Validators.required],
      // preco: ['', Validators.required]
    })
  }

  ngOnInit(): void
  {

  }

  adicionar()
  {
    // const produto: Produto =
    const produto: Produto =
    {
      categoria: this.adicionarProduto.get('categoria')?.value,
      nome: this.adicionarProduto.get('nome')?.value,
      fabricacao: this.adicionarProduto.get('fabricacao')?.value,
      validade: this.adicionarProduto.get('validade')?.value,
      preco: this.adicionarProduto.get('preco')?.value
    }

    this._produtoService.adicionar(produto).subscribe(data => {
      this.router.navigate(['/']);
    }, error => {
      console.log(error);
    });


  }
}
