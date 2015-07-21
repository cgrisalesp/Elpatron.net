using System.Linq;
using System.Web.Mvc;
using Dominio;
using Presentacion.Models;
using System;

namespace Presentacion.Controllers
{
    public class ReservasController : Controller
    {
        private readonly IFactoryReservas _factoryReservas;

        public ReservasController()
        {
            _factoryReservas = new FactoryReservas();
        }

        public ActionResult Index()
        {
            var reservas = _factoryReservas.ObtenerReservas();
            return View(reservas);
        }

        public ActionResult Reservar()
        {
            var zonasComunes =
                _factoryReservas.ObtenerTiposZonasComunes()
                    .Select(z => new SelectListItem {Value = z.Id.ToString(), Text = z.Nombre});
            var agregarReserva = new AgregarReserva
            {
                ZonasComunes = zonasComunes
            };

            return View(agregarReserva);
        }

        [HttpGet]
        public ActionResult Reservar1(int id, DateTime fecha)
        {
            _factoryReservas.Reservar(id,fecha);
            return RedirectToAction("Index");
        }

        public ActionResult SeleccionZonaComun(int id, DateTime fecha)
        {
            var zonas = _factoryReservas.ObtenerZonasComunesPorTipo(id);
            var model = new SeleccionZonaComun()
            {
                ZonasComunes = zonas,
                Fecha = fecha
            };
            return View(model);
        }
    }
}