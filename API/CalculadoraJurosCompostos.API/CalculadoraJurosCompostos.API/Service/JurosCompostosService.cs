using CalculadoraJurosCompostos.API.Service.IService;

namespace CalculadoraJurosCompostos.API.Service
{
    public class JurosCompostosService : IJurosCompostosService
    {
        public double CalcularJurosCompostos(double valorAplicado, double taxaJuros, int numeroPeriodos)
        {
            if (valorAplicado <= 0)
            {
                throw new ArgumentException("O valor aplicado deve ser maior que zero.", nameof(valorAplicado));
            }

            if (taxaJuros <= 0)
            {
                throw new ArgumentException("A taxa de juros anual deve ser maior que zero.", nameof(taxaJuros));
            }

            if (numeroPeriodos <= 0)
            {
                throw new ArgumentException("O número de períodos de tempo deve ser maior que zero.", nameof(numeroPeriodos));
            }

            double taxaDecimal = taxaJuros / 100;
            double valorFuturo = valorAplicado * Math.Pow(1 + taxaDecimal, numeroPeriodos);            
            return valorFuturo;
        }
    }
}
