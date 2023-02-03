using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Cliente.Dominio.Entidades;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;
using Clientes = Biblioteca.Gateway.Api.ClienteClient;

using Biblioteca.Cliente.Aplicacion.Cliente;
using Biblioteca.Gateway.Api.ClienteClient;

namespace Biblioteca.Cliente.Api.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly Clientes.IClient _client;

        public ClienteController(IClient client)
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