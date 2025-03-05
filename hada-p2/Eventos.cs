using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hada;

namespace Hada
{
    internal class TocadoArgs : EventArgs
    {
        public string nombre { set; get; }

        public Coordenada coordenadaImpacto { set; get; }

        public TocadoArgs(string nombre, Coordenada coordenadaImpacto)
        {
            this.nombre = nombre;
            this.coordenadaImpacto = coordenadaImpacto;
        }
    }

    internal class HundidoArgs : EventArgs
    {
        public string nombre;

        public HundidoArgs(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
