using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez_Nerv
{
    class Alfil : Ficha
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public char Tipo_Ficha { get; set; }
        public char Color_Ficha { get; set; }

        /// <summary>
        /// Constructor Alfil inicializa las propiedades de la interfaz
        /// </summary>
        /// <param name="tipoFicha"></param>
        /// <param name="colorFicha"></param>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        public Alfil(char tipoFicha, char colorFicha, int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Tipo_Ficha = tipoFicha;
            Color_Ficha = colorFicha;
        }

        /// <summary>
        /// Metodo utilizado para validar los movimientos del alfil
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

            if (filaa > Fila && colum > Columna)
            {
                for (int i = 0; i < filaa - Fila; i++)
                {
                    if (Tablero.tablero[fil + 1, col + 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil += 1;
                    col += 1;
                }
            }
            else if (filaa > Fila && colum < Columna)
            {
                for (int i = 0; i < filaa - Fila; i++)
                {
                    if (Tablero.tablero[fil + 1, col - 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil += 1;
                    col -= 1;
                }
            }
            else if (filaa < Fila && colum > Columna)
            {
                for (int i = 0; i < Fila - filaa; i++)
                {
                    if (Tablero.tablero[fil - 1, col + 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil -= 1;
                    col += 1;
                }
            }
            else if (filaa < Fila && colum < Columna)
            {
                for (int i = 0; i < Fila - filaa; i++)
                {
                    if (Tablero.tablero[fil - 1, col - 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil -= 1;
                    col -= 1;
                }
            }
            else
            {
                mover = false;
            }

            return mover;
        }

        /// <summary>
        /// Metodo utilizado para validar la captura de los movimientos
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        public bool Capturar(int fila, int columna)
        {
            var filaa = fila;
            var colum = columna;
            var mover = true;
            var fil = Fila;
            var col = Columna;

            if (filaa > Fila && colum > Columna)
            {
                for (int i = 0; i < (filaa - Fila) - 1; i++)
                {
                    if (Tablero.tablero[fil + 1, col + 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil += 1;
                    col += 1;
                }
            }
            else if (filaa > Fila && colum < Columna)
            {
                for (int i = 0; i < (filaa - Fila) - 1; i++)
                {
                    if (Tablero.tablero[fil + 1, col - 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil += 1;
                    col -= 1;
                }
            }
            else if (filaa < Fila && colum > Columna)
            {
                for (int i = 0; i < (Fila - filaa) - 1; i++)
                {
                    if (Tablero.tablero[fil - 1, col + 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil -= 1;
                    col += 1;
                }
            }
            else if (filaa < Fila && colum < Columna)
            {
                for (int i = 0; i < (Fila - filaa) - 1; i++)
                {
                    if (Tablero.tablero[fil - 1, col - 1] != null)
                    {
                        mover = false;
                        break;
                    }
                    fil -= 1;
                    col -= 1;
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
