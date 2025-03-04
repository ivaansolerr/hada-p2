using System;
using System.Collections.Generic;
using System.Linq;
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
            barcos.Add(new Barco("BARCO1", 2, 'v', new Coordenada(1, 0)));
            Tablero t = new Tablero(4,barcos);
            Console.WriteLine(t.ToString());
            
        }
    }
}
