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
            double valorComJuros = _jurosCompostosService.CalcularJurosCompostos(valorInicial, taxaJuros, numeroPeriodos);
            return Ok(valorComJuros);
        }
    }
}