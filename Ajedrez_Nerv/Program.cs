using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Program
    {
        public static int turno = 1;
        static void Main(string[] args)
        {
            bool  continuar = true;
            int fila, columna, nueva_fila, nueva_columna;
            String nombre_pieza;
            Tablero tablero = new Tablero();
            tablero.Inicializar();

            Console.Write("---- Ajedrez Nerv Team ----\n\n\n");
            while (continuar)
            {
                tablero.Imprimir();
                if (turno==1)
                {
                    Console.Write("\n\n---Turno Fichas Blancas---\n¿Que pieza desea mover?: ");

                }
                else
                {
                    Console.Write("\n\n---Turno Fichas Negras---\n¿Que pieza desea mover?: ");

                }
                nombre_pieza = Console.ReadLine();
                Console.Write("\nFila: ");
                fila = int.Parse(Console.ReadLine());
                Console.Write("\nColumna: ");
                columna = int.Parse(Console.ReadLine());
                Console.Write("\nSeleccione la casilla a donde sea mover...\nFila:");
                nueva_fila = int.Parse(Console.ReadLine());
                Console.Write("\nColumna:");
                nueva_columna = int.Parse(Console.ReadLine());

                
                    if (tablero.Mover_Pieza(nombre_pieza, fila, columna, nueva_fila, nueva_columna))
                    {
                        Console.Write("\nPieza se movio satisfactoriamente");
                        Console.WriteLine();
                        Console.WriteLine();
                        if (turno==1)
                        {
                            turno = 0;
                        }
                        else
                        {
                            turno = 1;
                        }
                    }
                    else
                    {
                        Console.Write("\nError al mover la pieza\n");

                    }
            }
        }
    }
}
