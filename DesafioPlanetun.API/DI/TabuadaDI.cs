using DesafioPlanetun.Business.Business;
using DesafioPlanetun.DataStream.Repository;
using DesafioPlanetun.DataStream.StreamWrapperFolder;
using DesafioPlanetun.Domain.Business;
using DesafioPlanetun.Domain.Repository;

namespace DesafioPlanetun.API.DI
{
    public class TabuadaDI
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITabuadaBusiness, TabuadaBusiness>();
            services.AddScoped<ITabuadaRepository, TabuadaRepository>();
            services.AddScoped<IStreamWrapper, StreamWrapper>();
        }
    }
}
