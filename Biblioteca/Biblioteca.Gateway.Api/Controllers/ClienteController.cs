using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Clientes = Biblioteca.Gateway.Aplicacion.ClientesClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;

namespace Biblioteca.Gateway.Api.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly Clientes.IClient _client;

        public ClienteController(Clientes.IClient client)
        {
            _client = client;
        }

        [HttpGet(RouteCliente.GetAll)]
        public Task<ICollection<Clientes.Cliente>> ListarClientes()
        {
            var listaClientes = _client.ApiV1ClienteAllAsync();
            return listaClientes;
        }
    }
}