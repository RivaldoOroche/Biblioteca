using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Autor.Dominio.Entidades;
using static Biblioteca.Autor.Api.Routes.ApiRoutes;
using Biblioteca.Autor.Aplicacion.Autor;

namespace Biblioteca.Autor.Api.Controllers
{
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly IAutorService _service;

        public AutorController(IAutorService service)
        {
            _service = service;
        }

        [HttpGet(RouteAutor.GetAll)]
        public IEnumerable<dominio.Autor> ListarAutors()
        {

            var listaAutor = _service.ListarAutors();
            return listaAutor;
        }

        [HttpGet(RouteAutor.GetById)]
        public dominio.Autor BuscarAutor(int id)
        {
            var objAutor = _service.Autor(id);

            return objAutor;
        }

        [HttpPost(RouteAutor.Create)]
        public ActionResult<dominio.Autor> CrearAutor([FromBody] dominio.Autor Autor)
        {
            _service.RegistrarAutor(Autor);

            return Ok();
        }

        [HttpDelete(RouteAutor.Delete)]
        public ActionResult<dominio.Autor> EliminarAutor(int id)
        {
            _service.Eliminar(id);

            return Ok(id);
        }
    }
}