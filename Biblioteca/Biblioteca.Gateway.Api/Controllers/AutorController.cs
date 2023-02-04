using Microsoft.AspNetCore.Mvc;
using Autores = Biblioteca.Gateway.Aplicacion.AutorClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;

namespace Biblioteca.Gateway.Api.Controllers
{
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly Autores.IClient _autoresClient;

        public AutorController(Autores.IClient autoresClient)
        {
            _autoresClient = autoresClient;
        }

        [HttpGet(RouteCliente.GetAll)]
        public Task<ICollection<Autores.Autor>> ListarAutores()
        {
            var listaAutores = _autoresClient.ApiV1AutorAllAsync();
            return listaAutores;
        }
    }
}
