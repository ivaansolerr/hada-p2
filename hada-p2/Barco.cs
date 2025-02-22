using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    internal class Barco
    {
        private string nombre;
        private int longitud;
        private char orientación;
        private Coordenada coordenadaInicio;

        public Dictionary<Coordenada, String> CoordenadasBarco;
        public string Nombre;
        public int NumDanyos;

        public Barco(string nombre, int longitud, char orientación, Coordenada coordenadaInicio)
        {
            this.nombre = nombre;
            this.longitud = longitud;
            this.orientación = orientación;
            this.coordenadaInicio = coordenadaInicio;

            CoordenadasBarco = new Dictionary<Coordenada, string>();
            Nombre = nombre;
            NumDanyos = 0;

            for (int i = 0; i < longitud; i++)
            {
                if (orientación == 'h')
                {
                    CoordenadasBarco[Coordenada(coordenadaInicio.fila() + i, coordenadaInicio.columna())] = nombre;
                }

                else if (orientación == 'v')
                {
                    CoordenadasBarco[Coordenada(coordenadaInicio.fila(), coordenadaInicio.columna() + i)] = nombre;
                }
            }
        }
    }
}
