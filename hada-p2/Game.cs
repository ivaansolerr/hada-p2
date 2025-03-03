using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    internal class Game
    {
        private bool finPartida;

        private void gameLoop()
        {
            Barco b1 = new Barco("Alpha", 4, 'h', new Coordenada(1, 1));
            Barco b2 = new Barco("Beta", 3, 'v', new Coordenada(2, 1));
            Barco b3 = new Barco("Gamma", 2, 'v', new Coordenada(5, 3));

            List<Barco> barcos = new List<Barco>();
            barcos.Add(b1);
            barcos.Add(b2);
            barcos.Add(b3);

            Tablero T = new Tablero(6, barcos);

            String input = null;

            while(!finPartida && input != 's' && input != 'S')
            {
                do
                {
                    Console.WriteLine("Enter a coordinate: ");
                    input = Console.ReadLine();

                    if (!validFormat(input))
                    {
                        Console.WriteLine("Invalid coordinate format.");
                    }

                } while (!validFormat(input));

                Coordenada c = new Coordenada((int)char.GetNumericValue(input[0]), (int)char.GetNumericValue(input[2]));
                T.Disparar(c);
            }
        }

        public bool validFormat(String input)
        {
            return input.Length == 3 && char.IsDigit(input[0]) && input[1] == ',' && char.IsDigit(input[2]);
        }

        public Game()
        {
            finPartida = false;
            gameLoop();
        }

        private void cuandoEventoFinPartida(EventArgs e)
        {
            Console.Write("GAME ENDED!");
            finPartida = true;
        }
    }
}
