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
        public static bool continuar = true;
        public static String nueva_partida = "N";
        static void Main(string[] args)
        {
            while (nueva_partida.Equals("N"))
            {
                int fila, columna, nueva_fila, nueva_columna;
                String nombre_pieza;
                Tablero tablero = new Tablero();
                tablero.Inicializar();
                Console.Write("---- Ajedrez Nerv Team ----\n\n\n");
                while (continuar)
                {
                    tablero.Imprimir();
                    if (turno == 1)
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
                    Tablero.cls();

                    if (tablero.Mover_Pieza(nombre_pieza, fila, columna, nueva_fila, nueva_columna))
                    {
                        Console.Write("\nPieza se movio satisfactoriamente");
                        Console.WriteLine();
                        Console.WriteLine();
                        if (turno == 1)
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
                        Console.WriteLine();
                    }
                }
                if (turno == 1)
                {
                    Console.Write("PIEZAS NEGRAS GANA LA PARTIDA");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("PIEZAS BLANCAS GANA LA PARTIDA");
                    Console.WriteLine();                    
                }
                Console.Write("Presione N para reiniciar nueva partida...");
                Console.WriteLine();
                Console.Write("O cualquier otra tecla para salir....");
                Console.WriteLine();
                nueva_partida = Console.ReadLine();
                if (nueva_partida.Equals("N"))
                {
                    continuar = true;
                }
            }
        }
    }
}
