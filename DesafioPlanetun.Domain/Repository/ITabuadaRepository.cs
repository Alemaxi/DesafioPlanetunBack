using DesafioPlanetun.Domain.DTO.GerarTabuada;

namespace DesafioPlanetun.Domain.Repository
{
    public interface ITabuadaRepository
    {
        Task GravarTabuada(IEnumerable<TabuadaDTO> tabuada);
    }   
}
