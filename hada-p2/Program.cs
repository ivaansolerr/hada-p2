using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// prueba

namespace Hada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var barcos = new List<Barco>();
            Barco b = (new Barco("TRT", 1, 'v', new Coordenada(1, 0)));
            barcos.Add(new Barco("PDP", 1, 'h', new Coordenada(2, 2)));
            barcos.Add(b);
            Tablero t = new Tablero(4,barcos);
            Coordenada vv = new Coordenada(1, 0);
            t.Disparar(vv);
            Console.WriteLine(t.ToString());
            
        }
    }
}
