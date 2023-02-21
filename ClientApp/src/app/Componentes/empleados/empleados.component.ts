import { Component, OnInit, Inject } from '@angular/core';
import { EmpleadosService } from 'src/app/service/empleados.service';

@Component({
  selector: 'app-empleados',
  templateUrl: './empleados.component.html',
})
export class EmpleadosComponent implements OnInit {

  constructor(private empleadoService: EmpleadosService) { }

  ngOnInit(): void {
  }
  

}
