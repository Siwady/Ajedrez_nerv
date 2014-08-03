using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Torre : Ficha
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public char Tipo_Ficha { get; set; }
        public char Color_Ficha { get; set; }

        /// <summary>
        /// Constructor Torre inicializa las propiedades de la interfaz
        /// </summary>
        /// <param name="tipoFicha"></param>
        /// <param name="colorFicha"></param>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        public Torre(char tipoFicha, char colorFicha, int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Tipo_Ficha = tipoFicha;
            Color_Ficha = colorFicha;
        }

        /// <summary>
        /// Metodo utilizado para validar los movimientos de la Torre
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        public bool Mover(int fila, int columna)
        {
            var filaa = fila;
            var colum = columna;
            var mover = true;
            // fila actual
            var fil = Fila;
            //columna actual
            var col = Columna;

            if (filaa == Fila && colum > Columna)
            {
                for (int i = 0; i < colum - Columna; i++)
                {
                    if (Tablero.tablero[fil, col + 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    col += 1;
                }
            }
            else
                if (filaa == Fila && colum < Columna)
                {
                    for (int i = 0; i < Columna - colum; i++)
                    {
                        if (Tablero.tablero[fil, col - 1] != null)
                        {
                            mover = false;
                            break;
                        }
                        col -= 1;
                    }
                }
                else
                    if (colum == Columna && filaa > Fila)
                    {
                        for (int i = 0; i < filaa - Fila; i++)
                        {
                            if (Tablero.tablero[fil + 1, col] != null)
                            {
                                mover = false;
                                break;
                            }
                            fil += 1;
                        }
                    }
                    else
                        if (colum == Columna && filaa < Fila)
                        {
                            for (int i = 0; i < Fila - filaa; i++)
                            {
                                if (Tablero.tablero[fil - 1, col] != null)
                                {
                                    mover = false;
                                    break;
                                }
                                fil -= 1;
                            }
                        }
                        else
                        {
                            mover = false;
                        }
            return mover;
        }

        /// <summary>
        /// Metodo utilizado para validar captura de los movimientos
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        public bool Capturar(int fila, int columna)
        {
            var filaa = fila;
            var colum = columna;
            var mover = true;
            // fila actual
            var fil = Fila;
            //columna actual
            var col = Columna;

            if (filaa == Fila && colum > Columna)
            {
                for (int i = 0; i < (colum - Columna) - 1; i++)
                {
                    if (Tablero.tablero[fil, col + 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    col += 1;
                }
            }
            else
                if (filaa == Fila && colum < Columna)
                {
                    for (int i = 0; i < (Columna - colum) - 1; i++)
                    {
                        if (Tablero.tablero[fil, col - 1] != null)
                        {
                            mover = false;
                            break;
                        }
                        col -= 1;
                    }
                }
                else
                    if (colum == Columna && filaa > Fila)
                    {
                        for (int i = 0; i < (filaa - Fila) - 1; i++)
                        {
                            if (Tablero.tablero[fil + 1, col] != null)
                            {
                                mover = false;
                                break;
                            }
                            fil += 1;
                        }
                    }
                    else
                        if (colum == Columna && filaa < Fila)
                        {
                            for (int i = 0; i < (Fila - filaa) - 1; i++)
                            {
                                if (Tablero.tablero[fil - 1, col] != null)
                                {
                                    mover = false;
                                    break;
                                }
                                fil -= 1;
                            }
                        }
                        else
                        {
                            mover = false;
                        }
            return mover;
        }
    }
}
