
using DesafioPlanetun.Domain.Business;
using DesafioPlanetun.Domain.DTO.GerarTabuada;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPlanetun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabuadaController : ControllerBase
    {
        readonly ITabuadaBusiness _tabuadaBusiness;

        public TabuadaController(ITabuadaBusiness tabuadaBusiness)
        {
            _tabuadaBusiness = tabuadaBusiness;
        }

        [HttpPost]
        public Task<IEnumerable<IEnumerable<TabuadaDTO>>> GerarTabuada(IEnumerable<int> numerosSelecionados)
        {
            if (numerosSelecionados == null || !numerosSelecionados.Any())
                throw new ArgumentException("Nenhum número foi informado para gerar a tabuada.");

            return _tabuadaBusiness.GerarTabuada(numerosSelecionados);
        }
    }
}
