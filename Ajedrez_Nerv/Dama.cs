using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Dama : Ficha
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public char Tipo_Ficha { get; set; }
        public char Color_Ficha { get; set; }

        public Dama(char tipo_ficha, char color_ficha, int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Tipo_Ficha = tipo_ficha;
            Color_Ficha = color_ficha;
        }
        public bool Mover(int fila, int columna)
        {
            bool move = true;
            int f3 = Fila;
            int c3 = Columna;

            if ((fila > Fila && columna > Columna) || (fila > Fila && columna < Columna) || (fila < Fila && columna > Columna)
                    || (fila < Fila && columna < Columna))
            {
                if (fila > Fila && columna > Columna)
                {
                    for (int x = 0; x < fila - Fila; x++)
                    {
                        if (Tablero.tablero[f3 + 1, c3 + 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 += 1;
                            c3 += 1;
                        }
                    }
                }
                else if (fila > Fila && columna < Columna)
                {
                    for (int x = 0; x < fila - Fila; x++)
                    {
                        if (Tablero.tablero[f3 + 1, c3 - 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 += 1;
                            c3 -= 1;
                        }
                    }
                }
                else if (fila < Fila && columna > Columna)
                {
                    for (int x = 0; x < Fila - fila; x++)
                    {
                        if (Tablero.tablero[f3 - 1, c3 + 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 -= 1;
                            c3 += 1;
                        }
                    }
                }
                else if (fila < Fila && columna < Columna)
                {
                    for (int x = 0; x < Fila - fila; x++)
                    {
                        if (Tablero.tablero[f3 - 1, c3 - 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 -= 1;
                            c3 -= 1;
                        }
                    }
                }
                else
                {
                    move = false;
                }
            }
            else if ((fila == Fila && columna > Columna) || (fila == Fila && columna < Columna) || (columna == Columna && fila > Fila)
                   || (columna == Columna && fila < Fila))
            {
                if (fila == Fila && columna > Columna)
                {
                    for (int x = 0; x < columna - Columna; x++)
                    {
                        if (Tablero.tablero[f3, c3 + 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            c3 = +1;
                        }
                    }
                }
                else if (fila == Fila && columna < Columna)
                {
                    for (int x = 0; x < Columna - columna; x++)
                    {
                        if (Tablero.tablero[f3, c3 - 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            c3 -= 1;
                        }
                    }
                }
                else if (columna == Columna && fila > Fila)
                {
                    for (int x = 0; x < fila - Fila; x++)
                    {
                        if (Tablero.tablero[f3 + 1, c3] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 += 1;
                        }
                    }
                }
                else if (columna == Columna && fila < Fila)
                {
                    for (int x = 0; x < Fila - fila; x++)
                    {
                        if (Tablero.tablero[f3 - 1, c3] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 -= 1;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                move = false;
            }
            return move;


        }

        public bool Capturar(int fila, int columna)
        {


            bool move = true;
            int f3 = Fila;
            int c3 = Columna;

            if ((fila > Fila && columna > Columna) || (fila > Fila && columna < Columna) || (fila < Fila && columna > Columna)
                    || (fila < Fila && columna < Columna))
            {
                if (fila > Fila && columna > Columna)
                {
                    for (int x = 0; x < (fila - Fila) - 1; x++)
                    {
                        if (Tablero.tablero[f3 + 1, c3 + 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 += 1;
                            c3 += 1;
                        }
                    }
                }
                else if (fila > Fila && columna < Columna)
                {
                    for (int x = 0; x < (fila - Fila) - 1; x++)
                    {
                        if (Tablero.tablero[f3 + 1, c3 - 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 += 1;
                            c3 -= 1;
                        }
                    }
                }
                else if (fila < Fila && columna > Columna)
                {
                    for (int x = 0; x < (Fila - fila) - 1; x++)
                    {
                        if (Tablero.tablero[f3 - 1, c3 + 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 -= 1;
                            c3 += 1;
                        }
                    }
                }
                else if (fila < Fila && columna < Columna)
                {
                    for (int x = 0; x < (Fila - fila) - 1; x++)
                    {
                        if (Tablero.tablero[f3 - 1, c3 - 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 -= 1;
                            c3 -= 1;
                        }
                    }
                }
                else
                {
                    move = false;
                }
            }
            else if ((fila == Fila && columna > Columna) || (fila == Fila && columna < Columna) || (columna == Columna && fila > Fila)
                   || (columna == Columna && fila < Fila))
            {
                if (fila == Fila && columna > Columna)
                {
                    for (int x = 0; x < (columna - Columna) - 1; x++)
                    {
                        if (Tablero.tablero[f3, c3 + 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            c3 = +1;
                        }
                    }
                }
                else if (fila == Fila && columna < Columna)
                {
                    for (int x = 0; x < (Columna - columna) - 1; x++)
                    {
                        if (Tablero.tablero[f3, c3 - 1] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            c3 -= 1;
                        }
                    }
                }
                else if (columna == Columna && fila > Fila)
                {
                    for (int x = 0; x < (fila - Fila) - 1; x++)
                    {
                        if (Tablero.tablero[f3 + 1, c3] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 += 1;
                        }
                    }
                }
                else if (columna == Columna && fila < Fila)
                {
                    for (int x = 0; x < (Fila - fila) - 1; x++)
                    {
                        if (Tablero.tablero[f3 - 1, c3] != null)
                        {
                            move = false;
                            break;
                        }
                        else
                        {
                            f3 -= 1;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                move = false;
            }
            return move;
        }

    }
}
