using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Silla :IElemento
    {
        private int _cantidad;
        
        public int ObtenerCantidad(){
            return _cantidad;
        }
        public Silla(int cantidad)
        {
            _cantidad = cantidad;
         }
        public string ObtenerNombre()
        {
            return TipoElemento.Silla.ToString();
        }
    }
}
