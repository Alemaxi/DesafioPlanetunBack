using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPlanetun.DataStream.StreamWrapperFolder
{
    public class StreamWrapper: IStreamWrapper
    {
        readonly string _path;

        public StreamWrapper()
        {
            _path = Directory.GetCurrentDirectory();
        }

        public Task Write(string value, int numeroSelecionado)
        {
            var fullPath = Path.Combine(_path,$"Tabuada_de_{numeroSelecionado}");

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine(value);
            }

            return Task.CompletedTask;
        }

        
    }
}
