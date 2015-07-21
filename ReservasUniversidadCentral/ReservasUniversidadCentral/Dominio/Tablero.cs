using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tablero : IElemento
    {
        public int ObtenerCantidad()
        {
            return 1;
        }

        public string ObtenerNombre()
        {
            return TipoElemento.Tablero.ToString();
        }
    }
}
