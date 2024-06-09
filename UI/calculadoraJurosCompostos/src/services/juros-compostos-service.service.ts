// src/app/juros-compostos.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JurosCompostosService {
  private apiUrl = 'https://localhost:5001/api/JurosCompostos';

  constructor(private http: HttpClient) { }

  calcularJurosCompostos(valorAplicado: number, taxaJuros: number, numeroPeriodos: number): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}/calcular?principal=${valorAplicado}&taxaJuros=${taxaJuros}&numeroPeriodos=${numeroPeriodos}`);
  }
}
