using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class IZonaComun
    {
        protected int _capacidad;
        protected List<IElemento> _elementos;
        protected TipoZonaComun _tipo;
        public int ObtenerCapacidad()
        {
            return _capacidad;
        }
        public List<IElemento> ObtenerElementos(){
            return _elementos;
        }
        public abstract void AdicionarElemento(IElemento elemento);

        public string ObtenerDescripcion()
        {
            return _tipo.ToString();
        }
    }
}