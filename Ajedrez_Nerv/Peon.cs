using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Peon : Ficha
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public char Tipo_Ficha { get; set; }
        public char Color_Ficha { get; set; }

        public Peon(char tipo_ficha, char color_ficha, int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Tipo_Ficha = tipo_ficha;
            Color_Ficha = color_ficha;
        }
        public bool Mover(int fila, int columna)
        {
            if (this.Color_Ficha == 'B')
            {
                if (this.Fila > fila && this.Columna == columna)
                {
                    if (this.Fila == 6)
                    {
                        if ((this.Fila - fila) == 1 || (this.Fila - fila) == 2)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (this.Fila < 6 && this.Fila >= 1)
                    {
                        if ((this.Fila - fila) == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else if (this.Color_Ficha == 'N')
            {
                if (this.Fila < fila && this.Columna == columna)
                {
                    if (this.Fila == 1)
                    {
                        if ((fila - this.Fila) == 1 || (fila - this.Fila) == 2)
                        {
                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    }
                    else if (this.Fila >= 1 && this.Fila < 7)
                    {
                        if ((fila - this.Fila) == 1)
                        {

                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    }
                    else
                    {

                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Capturar(int fila, int columna)
        {
            if (this.Color_Ficha == 'B')
            {
                if (this.Fila > fila && (columna > 0 && columna <= 8 && (columna < this.Columna || columna > this.Columna)))
                {
                    if ((this.Fila - fila) == 1 && ((columna - this.Columna) == 1 || (columna - this.Columna) == -1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else if (this.Color_Ficha == 'N')
            {
                if (this.Fila < fila && (columna > 0 && columna <= 8 && (columna < this.Columna || columna > this.Columna)))
                {
                    if ((fila - this.Fila) == 1 && ((columna - this.Columna == 1) || (columna - this.Columna) == -1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
