using System;
using System.Collections.Generic;
using System.Linq;
using Datos;

namespace Dominio
{
    public class FactoryReservas : IFactoryReservas
    {
        private readonly UniversidadEntities _contexto;

        public FactoryReservas()
        {
            _contexto = new UniversidadEntities();
        }

        public IEnumerable<Reserva> ObtenerReservas()
        {
            return _contexto.Reservas.Select(r => new Reserva {Fecha = r.Fecha, ZonaComun = r.ZonasComune.Nombre});
        }

        public void Reservar(int zonaComun, DateTime fecha)
        {
            var reserva = new Datos.Reserva
            {
                ZonaComunId = zonaComun,
                Fecha = fecha
            };
            _contexto.Reservas.Add(reserva);
            _contexto.SaveChanges();
        }

        public IEnumerable<TiposZonaComun> ObtenerTiposZonasComunes()
        {
            return _contexto.TiposZonaComuns.ToList();
        }

        public IEnumerable<ZonasComune> ObtenerZonasComunesPorTipo(int tipoId)
        {
            return _contexto.ZonasComunes.Include("Elementos").Where(z => z.TipoZonaComunId == tipoId).ToList();
        }
    }
}