using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Presentacion.Models
{
    public class AgregarReserva
    {
        public int ZonaComun { get; set; }
        public IEnumerable<SelectListItem> ZonasComunes { get; set; }
        public DateTime Fecha { get; set; }
    }
}