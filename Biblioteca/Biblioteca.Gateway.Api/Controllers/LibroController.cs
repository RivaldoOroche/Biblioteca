using Microsoft.AspNetCore.Mvc;
using Libros = Biblioteca.Gateway.Aplicacion.LibroClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;

namespace Biblioteca.Gateway.Api.Controllers
{
    [ApiController]
    public class LibroController : ControllerBase
    {

        private readonly Libros.IClient _client;

        public LibroController(Libros.IClient client)
        {
            _client = client;
        }

        [HttpGet(RouteLibro.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public Task<ICollection<Libros.Libro>> ListarLibros()
        {
            var listaLibros = _client.ApiV1LibroAllAsync();
            return listaLibros;
        }
    }
}


