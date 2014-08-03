using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    interface Ficha
    {
        int Fila { get; set; }
        int Columna { get; set; }
        char Tipo_Ficha { get; set; }
        char Color_Ficha { get; set; }

        bool Mover(int fila, int columna);
        bool Capturar(int fila, int columna);
    }
}
