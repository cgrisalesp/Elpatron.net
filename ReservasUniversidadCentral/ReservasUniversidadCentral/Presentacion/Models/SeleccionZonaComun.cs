using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;

namespace Presentacion.Models
{
    public class SeleccionZonaComun
    {
        public DateTime Fecha { get; set; }
        public IEnumerable<ZonasComune> ZonasComunes{get;set;}
    }
}