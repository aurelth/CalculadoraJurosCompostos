namespace CalculadoraJurosCompostos.API.Service.IService
{
    public interface IJurosCompostosService
    {
        double CalcularJurosCompostos(double valorAplicado, double taxaJuros, int numeroPeriodos);
    }
}
