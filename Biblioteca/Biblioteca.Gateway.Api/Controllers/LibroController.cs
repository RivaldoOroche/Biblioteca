using Microsoft.AspNetCore.Mvc;
using Libros = Biblioteca.Gateway.Aplicacion.LibroClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;

namespace Biblioteca.Gateway.Api.Controllers
{
    [ApiController]
    public class LibroController : ControllerBase
    {

        private readonly Libros.IClient _libroClient;

        public LibroController(Libros.IClient libroClient)
        {
            _libroClient = libroClient;
        }

        [HttpGet(RouteCliente.GetAll)]
        public Task<ICollection<Libros.Libro>> ListarLibro()
        {
            var listaLibro = _libroClient.ApiV1LibroAllAsync();
            return listaLibro;

        }
    }
}


