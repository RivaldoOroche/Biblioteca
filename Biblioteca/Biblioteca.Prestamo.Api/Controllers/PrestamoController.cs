using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Prestamo.Dominio.Entidades;
using static Biblioteca.Prestamo.Api.Routes.ApiRoutes;
using Biblioteca.Prestamo.Aplicacion.Prestamo;

namespace Biblioteca.Prestamo.Api.Controllers
{
    [ApiController]
    public class PrestamoController : ControllerBase
    {

        private readonly IPrestamoService _service;

        public PrestamoController(IPrestamoService service)
        {
            _service = service;
        }

        [HttpGet(RoutePrestamo.GetAll)]
        public IEnumerable<dominio.Prestamo> ListarPrestamos()
        {

            var listaPrestamo = _service.ListarPrestamos();
            return listaPrestamo;
        }

        [HttpGet(RoutePrestamo.GetById)]
        public dominio.Prestamo BuscarPrestamo(int id)
        {
            var objPrestamo = _service.Prestamo(id);

            return objPrestamo;
        }

        [HttpPost(RoutePrestamo.Create)]
        public ActionResult<dominio.Prestamo> CrearPrestamo([FromBody] dominio.Prestamo prestamo)
        {
            _service.RegistrarPrestamo(prestamo);

            return Ok();
        }

        [HttpDelete(RoutePrestamo.Delete)]
        public ActionResult<dominio.Prestamo> EliminarPrestamo(int id)
        {
            _service.Eliminar(id);

            return Ok(id);
        }
    }
}