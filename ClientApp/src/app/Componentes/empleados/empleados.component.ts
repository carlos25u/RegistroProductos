import { Component, OnInit, Inject } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-empleados',
  templateUrl: './empleados.component.html',
})
export class EmpleadosComponent implements OnInit {

  http = Inject(HttpClientModule)

  constructor() { }

  ngOnInit(): void {
  }
  
  getEmpleados(){

  }

}
