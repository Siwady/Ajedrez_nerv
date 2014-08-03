using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Tablero
    {
        Ficha[,] tablero;

        public void Inicializar()
        {
            tablero=new Ficha[9,9];

            tablero[7,1] = new Torre('T', 'B', 7, 1);
            tablero[7,2] = new Caballo('C', 'B', 7, 2);
            tablero[7,3] = new Alfil('A', 'B', 7, 3);
            tablero[7,4] = new Dama('D', 'B', 7, 4);
            tablero[7,5] = new Rey('R', 'B', 7, 5);
            tablero[7,6] = new Alfil('A', 'B', 7, 6);
            tablero[7,7] = new Caballo('C', 'B', 7, 7);
            tablero[7,8] = new Torre('T', 'B', 7, 8);

            for (int c = 1; c < 9; c++)
            {
                tablero[6, c] = new Peon('P', 'B', 6, c);
            }

            for (int c = 1; c < 9; c++)
            {
                tablero[1,c] = new Peon('P', 'N', 1, c);
            }

            tablero[0,1] = new Torre('T', 'N', 0, 1);
            tablero[0,2] = new Caballo('C', 'N', 0, 2);
            tablero[0,3] = new Alfil('A', 'N', 0, 3);
            tablero[0,4] = new Dama('D', 'N', 0, 4);
            tablero[0,5] = new Rey('R', 'N', 0, 5);
            tablero[0,6] = new Alfil('A', 'N', 0, 6);
            tablero[0,7] = new Caballo('C', 'N', 0, 7);
            tablero[0,8] = new Torre('T', 'N', 0, 8);
        }

        public void Imprimir()
        {
            for(int f=0;f<(tablero.Length/9)-1;f++){
                Console.Write(f+"  ");
                for (int c = 1; c < tablero.Length/9; c++)
                {
                    if (tablero[f, c] == null)
                        Console.Write("--  ");
                    else
                    {
                        Console.Write(tablero[f, c].Tipo_Ficha.ToString()+tablero[f, c].Color_Ficha.ToString());
                        Console.Write("  ");

                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.Write("   ");
            for(int x=1;x<9;x++)
            {
                Console.Write(x+"   ");
            }
        }
    }
}
