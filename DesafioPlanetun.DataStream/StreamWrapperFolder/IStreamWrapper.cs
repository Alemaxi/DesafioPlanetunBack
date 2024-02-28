using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPlanetun.DataStream.StreamWrapperFolder
{
    public interface IStreamWrapper
    {
        Task Write(string value, int numeroSelecionado);
    }
}
