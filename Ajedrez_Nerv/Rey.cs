using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Rey : Ficha
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public char Tipo_Ficha { get; set; }
        public char Color_Ficha { get; set; }

        public Rey(char tipo_ficha, char color_ficha, int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Tipo_Ficha = tipo_ficha;
            Color_Ficha = color_ficha;
        }
        public bool Mover(int fila, int columna)
        {
            if (((Fila - fila) == 1 || (Fila - fila) == -1) || ((Columna - columna) == 1 || (Columna - columna) == -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Capturar(int fila, int columna)
        {
            return Mover(fila, columna);
        }

    }
}
