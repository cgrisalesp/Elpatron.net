using System.Collections.Generic;

namespace Dominio
{
    public class Auditorio : IZonaComun
    {
        public Auditorio(int capacidad)
        {
            _capacidad = capacidad;
            _elementos = new List<IElemento>();
            _tipo = TipoZonaComun.Auditorio;
        }

        public override void AdicionarElemento(IElemento elemento)
        {
            _elementos.Add(elemento);
        }
    }
}