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
            Alfil movimiento_Alfil = new Alfil(Tipo_Ficha, Color_Ficha, fila, columna);
            Torre movimiento_Torre = new Torre(Tipo_Ficha, Color_Ficha, fila, columna);
            Columna = columna;
            Fila = fila;
            return movimiento_Alfil.Mover(fila, columna) || movimiento_Torre.Mover(fila, columna);
        }

        public bool Capturar(int fila, int columna)
        {
            throw new NotImplementedException();
        }
    }
}
