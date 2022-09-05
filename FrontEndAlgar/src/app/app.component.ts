import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  {
  constructor(public router: Router) {}


  public agregarProducto()
  {
    this.router.navigate(['AgregarProductoComponent']); 
  }

  public comprarProducto()
  {
    alert('hola 2');
  }

  title = 'algar-tienda';
}
