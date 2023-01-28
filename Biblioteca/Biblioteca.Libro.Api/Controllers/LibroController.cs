using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Libro.Dominio.Entidades;
using static Biblioteca.Libro.Api.Routes.ApiRoutes;
using Biblioteca.Libro.Aplicacion.Libro;

namespace Biblioteca.Libro.Api.Controllers
{

    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroService _service;

        public LibroController(ILibroService service)
        {
            _service = service;
        }

        [HttpGet(RouteLibro.GetAll)]
        public IEnumerable<dominio.Libro> ListarLibros()
        {

            var listaLibro = _service.ListarLibros();
            return listaLibro;
        }

        [HttpGet(RouteLibro.GetById)]
        public dominio.Libro BuscarLibro(int id)
        {
            var objLibro = _service.Libro(id);

            return objLibro;
        }

        [HttpPost(RouteLibro.Create)]
        public ActionResult<dominio.Libro> CrearLibro([FromBody] dominio.Libro Libro)
        {
            _service.RegistrarLibro(Libro);

            return Ok();
        }

        [HttpDelete(RouteLibro.Delete)]
        public ActionResult<dominio.Libro> EliminarLibro(int id)
        {
            _service.Eliminar(id);

            return Ok(id);
        }
    }
}
