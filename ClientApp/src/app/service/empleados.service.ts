import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Empleados } from '../Modelos/Empleados.modelos';

@Injectable({
  providedIn: 'root'
})
export class EmpleadosService {

  private endpoint:String = environment.endPoint
  private url:String = this.endpoint+"Empleados/"

  constructor(private http:HttpClient) { }

  getEmpleados():Observable<Empleados[]>{
    return this.http.get<Empleados[]>(`${this.endpoint}GetEmpleados`)
  }

  postEmpleados(empleados:Empleados):Observable<Empleados>{
    return this.http.post<Empleados>(`${this.endpoint}PostEmpleados`, empleados)
  }

  putEmpleados(empleadoId:number, empleados:Empleados):Observable<Empleados>{
    return this.http.put<Empleados>(`${this.endpoint}PutEmpleados/${empleadoId}`, empleados)
  }

  DeleteEmpleados(empleadoId:number):Observable<void>{
    return this.http.delete<void>(`${this.endpoint}DeleteEmpleados/${empleadoId}`)
  }

}
