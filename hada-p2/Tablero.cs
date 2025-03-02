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

        public event EventHandler<EventArgs> eventoFinPartida;

        public Tablero(int TamTablero, List<Barco> barcos)
        {
            this.TamTablero= TamTablero;
            this.barcos.set(barcos);

            for (int i = 0; i < this.barcos.Count; i++)
            {
                this.barcos[i].eventoTocado += cuandoEventoTocado;
                this.barcos[i].eventoHundido += cuandoEventoHundido;
            }
        }

        private void inicializaCasillasTablero()
        {
            for (int i = 0; i < this.TamTablero; i++)
            {
                for (int j = 0; j < this.TamTablero; j++)
                {
                    // classify Casillas
                }
            }
        }

        public Disparar(Coordenada c)
        {

        }

        public string DibujarTablero()
        {

        }

        public string ToString()
        {

        }

        public void cuandoEventoTocado()
        {
            Console.WriteLine("fsdfls");
        }

        public void cuandoEventoHundido()
        {
            Console.WriteLine("fdsf");
            bool allSunk = true;
            
            for (int i = 0; (i < this.barcosEliminados.Count) && allSunk; i++)
            {
                // idk if the comparion is ok
                if (this.barcos[i] != this.barcosEliminados[i])
                {
                    allSunk = false;
                }
            }

            if (allSunk)
            {
                eventoFinPartida.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
