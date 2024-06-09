// src/app/juros-compostos.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class JurosCompostosService {

  constructor(private http: HttpClient) { }

  calcularJurosCompostos(valorAplicado: number, taxaJuros: number, numeroPeriodos: number): Observable<number> {
    return this.http.get<number>(`${environment.apiUrl}/calcularjuroscompostos?valorAplicado=${valorAplicado}&taxaJuros=${taxaJuros}&numeroPeriodos=${numeroPeriodos}`);
  }
}
