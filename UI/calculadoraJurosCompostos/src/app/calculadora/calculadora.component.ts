// src/app/calculadora/calculadora.component.ts
import { Component, OnInit } from '@angular/core';
import { JurosCompostosService } from 'src/services/juros-compostos-service.service';


@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.css']
})
export class CalculadoraComponent {
  valorAplicado: number = 0;
  taxaJuros: number = 0;
  numeroPeriodos: number = 0;
  valorFuturo: number | null = null;
  error: string | null = null;

  constructor(private jurosCompostosService: JurosCompostosService) { }

  calcular() {
    this.jurosCompostosService.calcularJurosCompostos(this.valorAplicado, this.taxaJuros, this.numeroPeriodos)
      .subscribe({
        next: (resultado) => {
          this.valorFuturo = resultado;
          this.error = null;
        },
        error: (err) => {
          this.valorFuturo = null;
          this.error = err.error;
        }
      });
  }
}
