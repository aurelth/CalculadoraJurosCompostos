using CalculadoraJurosCompostos.API.Service.IService;

namespace CalculadoraJurosCompostos.API.Service
{
    public class JurosCompostosService : IJurosCompostosService
    {
        public double CalcularJurosCompostos(double valorAplicado, double taxaJuros, int numeroPeriodos)
        {
            double taxaDecimal = taxaJuros / 100;
            double valorFuturo = valorAplicado * Math.Pow(1 + taxaDecimal, numeroPeriodos);            
            return valorFuturo;
        }
    }
}
