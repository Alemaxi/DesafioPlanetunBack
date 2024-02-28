using DesafioPlanetun.Business.Business;
using DesafioPlanetun.Domain.DTO.GerarTabuada;
using DesafioPlanetun.Domain.Repository;
using Moq;

namespace DesafioPlanetun.Tests.Business
{
    public class TabuadaBusinessTest
    {
        readonly Mock<ITabuadaRepository> _tabuadaRepositoryMock;

        public TabuadaBusinessTest()
        {
            _tabuadaRepositoryMock = new Mock<ITabuadaRepository>();
        }

        [Fact]
        public async void GerarTabuada()
        {
            var numerosSelecionados = new List<int> { 2, 3, 4 };

            var tabuadaBusiness = new TabuadaBusiness(_tabuadaRepositoryMock.Object);
            var resultado = await tabuadaBusiness.GerarTabuada(numerosSelecionados);

            _tabuadaRepositoryMock.Verify(x => x.GravarTabuada(It.IsAny<IEnumerable<TabuadaDTO>>()), Times.Exactly(3));
            Assert.Equal(3, resultado.Count());
        }
    }
}
