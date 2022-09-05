import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AgregarProductoComponent } from './agregar-producto/agregar-producto.component';
import { ComprarProductoComponent } from './comprar-producto/comprar-producto.component';

const routes: Routes = [
  { path: 'agregar', component: AgregarProductoComponent },
  { path: 'comprar', component: ComprarProductoComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
