using DesafioPlanetun.DataStream.StreamWrapperFolder;
using DesafioPlanetun.Domain.DTO.GerarTabuada;
using DesafioPlanetun.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPlanetun.DataStream.Repository
{
    public class TabuadaRepository : ITabuadaRepository
    {
        readonly IStreamWrapper _streamWrapper;

        public TabuadaRepository(IStreamWrapper streamWrapper)
        {
            _streamWrapper = streamWrapper;
        }

        public Task GravarTabuada(IEnumerable<TabuadaDTO> tabuada)
        {
            var linhasTabauda = tabuada.Select(tabuada =>
                $"{tabuada.NumeroSelecionado} x {tabuada.NumeroDaTabela} = {tabuada.Resultado}");
            
            String.Join("\n", linhasTabauda);

            _streamWrapper.Write(String.Join("\n", linhasTabauda), tabuada.First().NumeroSelecionado);

            return Task.CompletedTask;
        }
    }
}
