using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    internal class Tablero
    {
        private int _TamTablero;
        public int TamTablero {
            get { return _TamTablero; }
            set { 
                if (value >= 4 && value <= 9)
                {
                    _TamTablero = value;
                }
            }
        }

        private List<Coordenada> coordenadasDisparadas { get; set; }

        private List<Coordenada> coordenadasTocadas { get; set; }

        private List<Barco> barcos { get; set; }

        private List<Barco> barcosEliminados { get; set; }

        private Dictionary<Coordenada, string> casillasTablero { get; set; }

        public Tablero(int TamTablero, List<Barco> barcos)
        {
            this.TamTablero= TamTablero;
            for (int i = 0; i < barcos.Count; i++)
            {
                // initialize touch and sink events,
            }
        }

        private void inicializaCasillasTablero()
        {
            // classify the squares of the board
        }

    }
}
