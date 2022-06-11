import { Product } from './../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-edit-product',
  templateUrl: './add-edit-product.component.html',
  styleUrls: ['./add-edit-product.component.css']
})
export class AddEditProductComponent implements OnInit {

  adicionarProduto: FormGroup;

  constructor(private fb: FormBuilder) {
    this.adicionarProduto = this.fb.group({
      categoria: ['', Validators.required],
      nome: ['', Validators.required],
      fabricacao: ['', Validators.required],
      validade: ['', Validators.required],
      preco: ['', Validators.required]
    })
  }

  ngOnInit(): void {
  }

  adicionar(){
    console.log(this.adicionarProduto);

    const produto: Product = {
      categoria: this.adicionarProduto.get('categoria')?.value,
      nome: this.adicionarProduto.get('nome')?.value,
      fabricacao: this.adicionarProduto.get('fabricacao')?.value,
      validade: this.adicionarProduto.get('validade')?.value,
      preco: this.adicionarProduto.get('preco')?.value

    }

    console.log(produto);
  }
}
