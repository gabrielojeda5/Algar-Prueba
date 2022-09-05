
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, Validators } from '@angular/forms';


@Component({
  selector: 'app-agregar-producto',
  templateUrl: './agregar-producto.component.html',
  styleUrls: ['./agregar-producto.component.scss']
})
export class AgregarProductoComponent implements OnInit {

  selectedColor?:number;
  nombre?:string;
  monto?:string;

  formProducto: FormGroup;
  
  constructor(private _fb: FormBuilder, private http: HttpClient) { }

  ngOnInit(): void {
    this.selectedColor=null;
    this.formProducto = this._fb.group({
      nombre: ['', [Validators.required]],
      monto: ['', [Validators.required]],
      color: [null, [Validators.required]],
  });
  }


  guardar()
  {
    if(  this.formProducto.valid) 
    {
      this.http.post<any>('http://localhost:4200/api/productos', { 
        nombreproducto: this.nombre,
        monto: this.monto,
        id_color: this.selectedColor
      
      }
        
        ).subscribe(data => {
          alert(data);
    })
   
    }
    else
    {
      alert('El formulario esta incompleto');
    }
  
  }

}
