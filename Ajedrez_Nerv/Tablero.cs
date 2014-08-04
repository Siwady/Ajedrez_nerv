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
        public static Ficha[,] tablero;
        static int NEW_LINES = 500;
        public void Inicializar()
        {
            tablero = new Ficha[9, 9];

            tablero[7, 1] = new Torre('T', 'B', 7, 1);
            tablero[7, 2] = new Caballo('C', 'B', 7, 2);
            tablero[7, 3] = new Alfil('A', 'B', 7, 3);
            tablero[7, 4] = new Dama('D', 'B', 7, 4);
            tablero[7, 5] = new Rey('R', 'B', 7, 5);
            tablero[7, 6] = new Alfil('A', 'B', 7, 6);
            tablero[7, 7] = new Caballo('C', 'B', 7, 7);
            tablero[7, 8] = new Torre('T', 'B', 7, 8);

            for (int c = 1; c < 9; c++)
            {
                tablero[6, c] = new Peon('P', 'B', 6, c);
            }

            for (int c = 1; c < 9; c++)
            {
                tablero[1, c] = new Peon('P', 'N', 1, c);
            }

            tablero[0, 1] = new Torre('T', 'N', 0, 1);
            tablero[0, 2] = new Caballo('C', 'N', 0, 2);
            tablero[0, 3] = new Alfil('A', 'N', 0, 3);
            tablero[0, 4] = new Dama('D', 'N', 0, 4);
            tablero[0, 5] = new Rey('R', 'N', 0, 5);
            tablero[0, 6] = new Alfil('A', 'N', 0, 6);
            tablero[0, 7] = new Caballo('C', 'N', 0, 7);
            tablero[0, 8] = new Torre('T', 'N', 0, 8);
        }

        public void Imprimir()
        {
            Console.WriteLine();
            for (int f = 0; f < (tablero.Length / 9) - 1; f++)
            {
                Console.Write((tablero.Length / 9) - (f + 1) + "  ");
                for (int c = 1; c < tablero.Length / 9; c++)
                {
                    if (tablero[f, c] == null)
                        Console.Write("--  ");
                    else
                    {
                        Console.Write(tablero[f, c].Tipo_Ficha.ToString() + tablero[f, c].Color_Ficha.ToString());
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.Write("   ");
            for (int x = 1; x < 9; x++)
            {
                Console.Write(x + "   ");
            }
            Console.WriteLine();
        }

        public bool Mover_Pieza(String nc, int f, int c, int ff, int cc)
        {
            char name = nc.ToCharArray().ElementAt(0);
            char color = nc.ToCharArray().ElementAt(1);
            int fila = getFila(f);
            int columna = c;
            if ((Program.turno == 1 && Tablero.tablero[fila, columna].Color_Ficha == 'B') ||
                (Program.turno == 0 && Tablero.tablero[fila, columna].Color_Ficha == 'N'))
            {
                if (tablero[fila, columna] != null)
                {
                    if (tablero[fila, columna].Tipo_Ficha == name && tablero[fila, columna].Color_Ficha == color)
                    {
                        int newfila = getFila(ff);
                        int newcolumna = cc;

                        if (tablero[newfila, newcolumna] == null)
                        {
                            bool move = tablero[fila, columna].Mover(newfila, newcolumna);

                            if (move == true)
                            {
                                if (tablero[fila, columna].GetType().Name.CompareTo("Peon") == 0)
                                {
                                    tablero[newfila, newcolumna] = new Peon(tablero[fila, columna].Tipo_Ficha,
                                        tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                    tablero[fila, columna] = null;
                                    return true;
                                }
                                else if (tablero[fila, columna].GetType().Name.CompareTo("Caballo") == 0)
                                {
                                    tablero[newfila, newcolumna] = new Caballo(tablero[fila, columna].Tipo_Ficha,
                                        tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                    tablero[fila, columna] = null;
                                    return true;
                                }
                                else if (tablero[fila, columna].GetType().Name.CompareTo("Alfil") == 0)
                                {
                                    tablero[newfila, newcolumna] = new Alfil(tablero[fila, columna].Tipo_Ficha,
                                        tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                    tablero[fila, columna] = null;
                                    return true;
                                }
                                else if (tablero[fila, columna].GetType().Name.CompareTo("Torre") == 0)
                                {
                                    tablero[newfila, newcolumna] = new Torre(tablero[fila, columna].Tipo_Ficha,
                                        tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                    tablero[fila, columna] = null;
                                    return true;
                                }
                                else if (tablero[fila, columna].GetType().Name.CompareTo("Dama") == 0)
                                {
                                    tablero[newfila, newcolumna] = new Dama(tablero[fila, columna].Tipo_Ficha,
                                        tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                    tablero[fila, columna] = null;
                                    return true;
                                }
                                else if (tablero[fila, columna].GetType().Name.CompareTo("Rey") == 0)
                                {
                                    tablero[newfila, newcolumna] = new Rey(tablero[fila, columna].Tipo_Ficha,
                                        tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                    tablero[fila, columna] = null;
                                    return true;
                                }
                                else
                                {
                                    Console.Write("No Se Encontro Tipo de Pieza");
                                    Console.WriteLine();
                                    return false;
                                }
                            }
                            else
                            {
                                Console.Write("Funcion Mover Retorno Falso");
                                Console.WriteLine();
                                return false;
                            }
                        }
                        else if (tablero[newfila, newcolumna] != null)//SI LA NUEVA POSICION HAY UNA PIEZA PASA A LA CAPTURA
                        {
                            if (tablero[newfila, newcolumna].Color_Ficha == color)
                            {
                                Console.Write("No Se Puede Comer Pieza Mismo Color");
                                return false;
                            }
                            else
                            {
                                Console.WriteLine("Realiza una Captura");
                                bool cap = tablero[fila, columna].Capturar(newfila, newcolumna);
                                if (cap == true)
                                {
                                    if (tablero[newfila, newcolumna].GetType().Name.CompareTo("Rey") == 0)
                                    {
                                        Program.continuar = false;
                                    }
                                    if (tablero[fila, columna].GetType().Name.CompareTo("Peon") == 0)
                                    {
                                        tablero[newfila, newcolumna] = new Peon(tablero[fila, columna].Tipo_Ficha,
                                            tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                        tablero[fila, columna] = null;
                                        return true;
                                    }
                                    else if (tablero[fila, columna].GetType().Name.CompareTo("Caballo") == 0)
                                    {
                                        tablero[newfila, newcolumna] = new Caballo(tablero[fila, columna].Tipo_Ficha,
                                            tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                        tablero[fila, columna] = null;
                                        return true;
                                    }
                                    else if (tablero[fila, columna].GetType().Name.CompareTo("Rey") == 0)
                                    {
                                        tablero[newfila, newcolumna] = new Rey(tablero[fila, columna].Tipo_Ficha,
                                            tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                        tablero[fila, columna] = null;
                                        return true;
                                    }
                                    else if (tablero[fila, columna].GetType().Name.CompareTo("Torre") == 0)
                                    {
                                        tablero[newfila, newcolumna] = new Torre(tablero[fila, columna].Tipo_Ficha,
                                            tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                        tablero[fila, columna] = null;
                                        return true;
                                    }
                                    else if (tablero[fila, columna].GetType().Name.CompareTo("Dama") == 0)
                                    {
                                        tablero[newfila, newcolumna] = new Dama(tablero[fila, columna].Tipo_Ficha,
                                            tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                        tablero[fila, columna] = null;
                                        return true;
                                    }
                                    else if (tablero[fila, columna].GetType().Name.CompareTo("Alfil") == 0)
                                    {
                                        tablero[newfila, newcolumna] = new Alfil(tablero[fila, columna].Tipo_Ficha,
                                            tablero[fila, columna].Color_Ficha, newfila, newcolumna);
                                        tablero[fila, columna] = null;
                                        return true;
                                    }
                                    else
                                    {
                                        Console.Write("No Se Encontro Tipo de Pieza");
                                        Console.WriteLine();
                                        return false;
                                    }
                                }
                                else
                                {
                                    Console.Write("Funcion Capturar Retorno Falso");
                                    Console.WriteLine();
                                    return false;
                                }
                            }

                        }
                        else
                        {
                            Console.Write("Linea 153 Retorno Falso");
                            Console.WriteLine();
                            return false;
                        }
                    }
                    else
                    {
                        Console.Write("Nombre y Color No Coinciden");
                        Console.WriteLine();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("\nNo Hay Dicha Posicion");
                    Console.WriteLine();
                    return false;
                }
            }
            else
            {
                Console.Write("Pieza Seleccionada Incorrecta");
                Console.WriteLine();
                return false;
            }
        }

        private int getFila(int f)
        {
            switch (f)
            {
                case 1:
                    return 7;
                case 2:
                    return 6;
                case 3:
                    return 5;
                case 4:
                    return 4;
                case 5:
                    return 3;
                case 6:
                    return 2;
                case 7:
                    return 1;
                case 8:
                    return 0;
                default:
                    return 8;
            }
        }

        public static void cls()
        {
            cls(0);
        }

        private static void cls(int c)
        {
            if (c < NEW_LINES)
            {
                Console.WriteLine("");
                cls(c + 1);
            }
        }
    }
}
