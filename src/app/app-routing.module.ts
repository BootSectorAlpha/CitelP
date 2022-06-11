import { SeeProductComponent } from './components/see-product/see-product.component';
import { AddEditProductComponent } from './components/add-edit-product/add-edit-product.component';
import { ListProductComponent } from './components/list-product/list-product.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: '', component: ListProductComponent},
  {path: 'adicionar', component: AddEditProductComponent},
  {path: 'editar/:id', component: AddEditProductComponent },
  {path: 'see/:id', component: SeeProductComponent },
  {path: '**', redirectTo: '', pathMatch: 'full'}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
