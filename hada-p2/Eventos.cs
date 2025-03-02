﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hada;

namespace Hada
{
    internal class TocadoArgs : EventArgs
    {
        private string nombre;
        private Coordenada coordenadaImpacto;

        public TocadoArgs(string nombre, Coordenada coordenadaImpacto)
        {
            this.nombre = nombre;
            this.coordenadaImpacto = coordenadaImpacto;
        }
    }

    internal class HundidoArgs : EventArgs
    {
        private string nombre;

        public HundidoArgs(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
