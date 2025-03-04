﻿using System;
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
            casillasTablero = new Dictionary<Coordenada, string>();
            this.TamTablero= TamTablero;
            this.barcos = barcos;

            //for (int i = 0; i < this.barcos.Count; i++)
            //{
            //    this.barcos[i].eventoTocado += cuandoEventoTocado;
            //    this.barcos[i].eventoHundido += cuandoEventoHundido;
            //}
        }

        private void inicializaCasillasTablero()
        {
            for (int i = 0; i < TamTablero; i++)
            {
                for (int j = 0; j < TamTablero; j++)
                {
                    Coordenada c = new Coordenada(i, j);
                    casillasTablero.Add(c, "AGUA");

                    for (int k = 0; k < barcos.Count; k++)
                    {
                        if (barcos[k].CoordenadasBarco.ContainsKey(c))
                        {
                            casillasTablero[c] = barcos[k].Nombre;
                        }
                    }
                }
                
            }
        }

        public void Disparar(Coordenada c)
        {
            if(c.Fila > this.TamTablero || c.Columna > this.TamTablero
                || c.Fila < 4 || c.Columna > 4)
            {
                Console.WriteLine("The coordinate (" + c.Fila +
                    "," + c.Columna + ") is outside the dimensions of" +
                    "the board");
            }
        }

        public string DibujarTablero()
        {
            string tablero = "";

            for (int i = 0; i < TamTablero; i++)
            {
                for (int j = 0; j < TamTablero; j++)
                {
                    Coordenada c = new Coordenada(i, j);
                    this.casillasTablero.TryGetValue(c, out string value);
                    tablero += "[" +
                        value
                        + "]";
                }
                tablero += "\n";

            }

            return tablero;
        }

        public override string ToString()
        {
            this.inicializaCasillasTablero();
            return this.DibujarTablero();
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
