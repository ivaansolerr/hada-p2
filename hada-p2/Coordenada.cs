using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    internal class Coordenada
    {
        private int fila;
        private int columna;

        public int Fila { get; set; }
        public int Columna { get; set; }

        public Coordenada()
        {
            this.fila = 0;
            this.columna = 0;
        }
    }
}
