namespace CalculadoraJurosCompostos.API.Models
{
    public class JurosCompostos
    {        
        public decimal ValorInvestido { get; set; }
        public double TaxaDeJuros { get; set; }
        public int PeriodoInvestimento { get; set; }
        public decimal ValorFuturo { get; set; }
        public decimal GanhosEmJuros { get; set; }
    }
}