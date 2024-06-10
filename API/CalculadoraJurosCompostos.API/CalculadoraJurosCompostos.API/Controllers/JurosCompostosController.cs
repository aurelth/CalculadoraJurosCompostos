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
        public ActionResult<double> CalcularJurosCompostos(double valorAplicado, double taxaJuros, int numeroPeriodos)
        {
            double valorFuturo = _jurosCompostosService.CalcularJurosCompostos(valorAplicado, taxaJuros, numeroPeriodos);
            return Ok(valorFuturo);
        }
    }
}