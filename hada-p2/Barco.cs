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
        public Dictionary<Coordenada, String> CoordenadasBarco;
        public string Nombre;
        public int NumDanyos;

        private bool _tocado;

        public event EventHandler<TocadoArgs> eventoTocado;
        public event EventHandler<HundidoArgs> eventoHundido;

        public Barco(string nombre, int longitud, char orientación, Coordenada coordenadaInicio)
        {
            CoordenadasBarco = new Dictionary<Coordenada, string>();
            Nombre = nombre;
            NumDanyos = 0;

            for (int i = 0; i < longitud; i++)
            {
                if (orientación == 'h')
                {
                    CoordenadasBarco[new Coordenada(coordenadaInicio.Fila + i, coordenadaInicio.Columna)] = nombre;
                }

                else if (orientación == 'v')
                {
                    CoordenadasBarco[new Coordenada(coordenadaInicio.Fila, coordenadaInicio.Columna + i)] = nombre;
                }
            }
        }

        public void Disparo(Coordenada c)
        {
           for (int i = 0;i < CoordenadasBarco.Count;i++)
           {
                if (CoordenadasBarco.ContainsKey(c))
                {
                    CoordenadasBarco[c] = Nombre + "_T";
                    NumDanyos++;

                   //ADD EVENTO TOCADO
                   //ADD EVENTO HUNDIDO IF ES EL CASO
                }
           }
        }

        public bool hundido()
        {
            if (CoordenadasBarco.ContainsValue(Nombre))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            string text = "[" + Nombre + "] - DAÑOS: [" + NumDanyos + "] - HUNDIDO: [" + hundido() +
                "] - COORDENADAS:";

            List<KeyValuePair<Coordenada, string>> lista = new List<KeyValuePair<Coordenada, string>>(CoordenadasBarco);

            for (int i = 0; i < lista.Count; i++)
            {
                text += " [" + lista[i].Key + " :" + lista[i].Value + "]";
            }

            return text;
        }
    }
}
