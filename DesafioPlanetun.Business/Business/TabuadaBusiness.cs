using DesafioPlanetun.Domain.Business;
using DesafioPlanetun.Domain.DTO.GerarTabuada;
using DesafioPlanetun.Domain.Repository;
using System.Collections.Generic;

namespace DesafioPlanetun.Business.Business
{
    public class TabuadaBusiness : ITabuadaBusiness
    {
        readonly ITabuadaRepository _tabuadaRepository;

        public TabuadaBusiness(ITabuadaRepository tabuadaRepository)
        {
            _tabuadaRepository = tabuadaRepository;
        }

        public async Task<IEnumerable<IEnumerable<TabuadaDTO>>> GerarTabuada(IEnumerable<int> numerosSelecionados)
        {
            List<List<TabuadaDTO>> tabuadas = new();

            foreach (var item in numerosSelecionados)
            {
                var tabuada = (List<TabuadaDTO>)GerarTabuada(item);
                tabuadas.Add(tabuada);
                await _tabuadaRepository.GravarTabuada(tabuada);
            }

            return tabuadas;
        }


        public IEnumerable<TabuadaDTO> GerarTabuada(int numeroSelecionado)
        {
            List<TabuadaDTO> tabuada = new();

            for (int index = 1; index <= 10; index++)
            {
                tabuada.Add(new TabuadaDTO
                {
                    NumeroSelecionado = numeroSelecionado,
                    NumeroDaTabela = index,
                    Resultado = numeroSelecionado * index
                });
            }

            return tabuada;
        }
    }
}
