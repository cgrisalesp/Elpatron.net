using System;
using System.Collections.Generic;
using Datos;

namespace Dominio
{
    public interface IFactoryReservas
    {
        IEnumerable<Reserva> ObtenerReservas();
        void Reservar(int zonaComun, DateTime fecha);
        IEnumerable<TiposZonaComun> ObtenerTiposZonasComunes();

        IEnumerable<ZonasComune> ObtenerZonasComunesPorTipo(int tipoId);
    }
}