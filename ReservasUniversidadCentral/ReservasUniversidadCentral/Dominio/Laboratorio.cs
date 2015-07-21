using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Laboratorio : IZonaComun
    {
        public Laboratorio(int capacidad)
        {
            _capacidad = capacidad;
            _elementos = new List<IElemento>();
            _tipo = TipoZonaComun.Laboratorio;
        }

        public override void AdicionarElemento(IElemento elemento)
        {
            _elementos.Add(elemento);
        }
    }
}
