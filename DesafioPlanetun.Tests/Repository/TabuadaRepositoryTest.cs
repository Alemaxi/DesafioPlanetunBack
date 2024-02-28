using DesafioPlanetun.DataStream.Repository;
using DesafioPlanetun.DataStream.StreamWrapperFolder;
using DesafioPlanetun.Domain.DTO.GerarTabuada;
using Moq;

namespace DesafioPlanetun.Tests.Repository
{
    public class TabuadaRepositoryTest
    {
        readonly Mock<IStreamWrapper> _streamWrapperMock;

        public TabuadaRepositoryTest()
        {
            _streamWrapperMock = new Mock<IStreamWrapper>();
        }

        [Fact]
        public async void GravarTabuada()
        {
            var tabuada = new List<TabuadaDTO>
            {
                new TabuadaDTO
                {
                    NumeroDaTabela = 1,
                    NumeroSelecionado = 2,
                    Resultado = 2
                }
            };

            _streamWrapperMock.Setup(x => x.Write(It.IsAny<string>(), It.IsAny<int>()));

            var tabuadaRepository = new TabuadaRepository(_streamWrapperMock.Object);
            await tabuadaRepository.GravarTabuada(tabuada);

            _streamWrapperMock.Verify(x => x.Write(It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }
    }
}
