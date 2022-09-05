import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { AgregarProductoComponent } from './agregar-producto/agregar-producto.component';
import { ComprarProductoComponent } from './comprar-producto/comprar-producto.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AgregarProductoComponent,
    ComprarProductoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
       HttpClientModule,
       FormsModule,
       ReactiveFormsModule ,
       BrowserModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
