using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aula :IZonaComun
    {
        public Aula(int capacidad)
        {
            _capacidad = capacidad;
            _elementos = new List<IElemento>();
            _tipo = TipoZonaComun.Aula;
        }
        public override void AdicionarElemento(IElemento elemento)
        {
            if (elemento.GetType().Name == "Silla" )
            {
                int cantidad = elemento.ObtenerCantidad();
                if (cantidad > 50) {
                    throw new Exception("Un Aula no puede contener mas de 50 sillas");
                }
                
            }
            _elementos.Add(elemento);
        }        
    }
}
