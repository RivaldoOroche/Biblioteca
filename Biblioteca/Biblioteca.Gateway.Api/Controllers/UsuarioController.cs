using Microsoft.AspNetCore.Mvc;
using Usuarios = Biblioteca.Gateway.Aplicacion.UsuarioClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;
namespace Biblioteca.Gateway.Api.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly Usuarios.IClient _client;

        public UsuarioController(Usuarios.IClient client)
        {
            _client = client;
        }

        [HttpGet(RouteUsuario.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public Task<ICollection<Usuarios.Usuario>> ListarUsuarios()
        {
            var listaUsuarios = _client.ApiV1UsuarioAllAsync();
            return listaUsuarios;
        }
    }
}
