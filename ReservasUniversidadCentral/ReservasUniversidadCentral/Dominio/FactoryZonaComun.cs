using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FactoryZonaComun
    {
        private IList<IZonaComun> _repositorio;
        public FactoryZonaComun()
        {
            _repositorio = new List<IZonaComun>();
        }
        public void Agregar(IZonaComun zonaComun){
            _repositorio.Add(zonaComun);
        }

        public List<IZonaComun> ObtenerTodas()
        {
            return _repositorio.ToList();
        }
    }
}
