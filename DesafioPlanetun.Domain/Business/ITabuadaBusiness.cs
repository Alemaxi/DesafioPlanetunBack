using DesafioPlanetun.Domain.DTO.GerarTabuada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPlanetun.Domain.Business
{
    public interface ITabuadaBusiness
    {
        Task<IEnumerable<IEnumerable<TabuadaDTO>>> GerarTabuada(IEnumerable<int> numerosSelecionados);
    }
}
