using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Autores = Biblioteca.Gateway.Aplicacion.AutorClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;


namespace Biblioteca.Gateway.Api.Controllers
{
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly Autores.IClient _client;

        public AutorController(Autores.IClient client)
        {
            _client = client;
        }

        [HttpGet(RouteAutor.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public Task<ICollection<Autores.Autor>> ListarAutores()
        {
            var listaAutores = _client.ApiV1AutorAllAsync();
            return listaAutores;
        }
    }
}
