import { ProductService } from './../../services/product.service';
import { Produto } from './../../interfaces/Produto';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-edit-product',
  templateUrl: './add-edit-product.component.html',
  styleUrls: ['./add-edit-product.component.css']
})
export class AddEditProductComponent implements OnInit {

  adicionarProduto: FormGroup;
  acao = 'Adicionar';
  id = 0;
  produto: Produto | undefined;

  constructor(private fb: FormBuilder,
              private _produtoService: ProductService,
              private router: Router,
              private aRoute: ActivatedRoute,
              private toastr: ToastrService) {
    this.adicionarProduto = this.fb.group({
      categoria: ['', Validators.required],
      nome: ['', Validators.required],
      fabricacao: ['', Validators.required],
      validade: ['', Validators.required],
      preco: ['', Validators.required]
    })
    this.id = +this.aRoute.snapshot.paramMap.get('id')!;
  }

  ngOnInit(): void
  {
    this.eEditar();
  }

  eEditar(){
    if(this.id !== 0){
      this.acao = 'Editar';
      this._produtoService.getProduto(this.id).subscribe(data => {
        this.produto = data;
        this.adicionarProduto.patchValue({
          categoria: data.categoria,
          nome: data.nome,
          fabricacao: data.fabricacao,
          validade: data.validade,
          preco: data.preco,
        })
      }, error => {
        console.log(error);
      })
    }
  }

  adicionarEditarProduto()
  {
    if(this.produto == undefined)
    {

    //adiciona um novo produto
    const produto: Produto =
    {
      categoria: this.adicionarProduto.get('categoria')?.value,
      nome: this.adicionarProduto.get('nome')?.value,
      fabricacao: new Date,
      validade: new Date,
      preco: this.adicionarProduto.get('preco')?.value
    }

    this._produtoService.adicionar(produto).subscribe(data => {
      this.toastr.success('O Produto foi Registrado com Sucesso!', 'Produto Registrado!');
      this.router.navigate(['/']);
    }, error => {
      console.log(error);
    });

    }
    else{
      //Edita um Produto
      const produto: Produto =
    {
      id: this.produto.id,
      categoria: this.adicionarProduto.get('categoria')?.value,
      nome: this.adicionarProduto.get('nome')?.value,
      fabricacao: this.produto.fabricacao,
      validade: this.produto.validade,
      preco: this.adicionarProduto.get('preco')?.value
    }

      this._produtoService.updateProduto(this.id, produto).subscribe(data => {
        this.toastr.info('O Produto foi Editado com Sucesso!', 'Produto Atualizado!');
        this.router.navigate(['/']);
      }, error => {
        console.log(error);
      });

    }



  }
}
