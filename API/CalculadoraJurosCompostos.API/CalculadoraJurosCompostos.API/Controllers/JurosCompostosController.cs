using CalculadoraJurosCompostos.API.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraJurosCompostos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosCompostosController : ControllerBase
    {
        private readonly IJurosCompostosService _jurosCompostosService;

        public JurosCompostosController(IJurosCompostosService jurosCompostosService)
        {
            _jurosCompostosService = jurosCompostosService;
        }

        [HttpGet]
        public ActionResult<double> CalcularJurosCompostos(double valorInicial, double taxaJuros, int numeroPeriodos)
        {
            if (valorInicial <= 0)
            {
                return BadRequest("O valor inicial deve ser maior que zero.");
            }

            if (taxaJuros <= 0)
            {
                return BadRequest("A taxa de juros deve ser maior que zero.");
            }

            if (numeroPeriodos <= 0)
            {
                return BadRequest("O número de períodos deve ser maior que zero.");
            }

            double valorComJuros = _jurosCompostosService.CalcularJurosCompostos(valorInicial, taxaJuros, numeroPeriodos);
            return Ok(valorComJuros);
        }
    }
}