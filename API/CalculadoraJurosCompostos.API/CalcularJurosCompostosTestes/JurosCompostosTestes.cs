using CalculadoraJurosCompostos.API.Service;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CalcularJurosCompostosTestes
{
    [TestClass]
    public class JurosCompostosTestes
    {
        private JurosCompostosService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new JurosCompostosService();
        }

        [TestMethod]
        public void CalculaJurosCompostos_ValidInput_CalculaCorretamente()
        {
            //Arrange
            double valorAplicado = 10000;
            double taxaJuros = 5;
            int numeroPeriodos = 5;
            double expected = 12762.815625000003;


            //Act
            double result = _service.CalcularJurosCompostos(valorAplicado, taxaJuros, numeroPeriodos);

            //Assert            
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }

        [TestMethod]
        public void CalculaJurosCompostos_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            double valorAplicado = -10000;
            double taxaJuros = 5;
            int numeroPeriodos = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _service.CalcularJurosCompostos(valorAplicado, taxaJuros, numeroPeriodos));
        }
    }
}