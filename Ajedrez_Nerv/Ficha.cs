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
        char Color_Fichañ { get; set; }

        bool Validar_Mover(int fila, int columna);
    }
}
