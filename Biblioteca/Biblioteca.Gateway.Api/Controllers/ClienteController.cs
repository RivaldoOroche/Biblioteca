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

        private readonly Clientes.IClient _clientesClient;

        public ClienteController(Clientes.IClient clientesCliente)
        {
            _clientesClient = clientesCliente;
        }

        [HttpGet(RouteCliente.GetAll)]
        public Task<ICollection<Clientes.Cliente>> ListarClientes()
        {
            var listaClientes = _clientesClient.ApiV1ClienteAllAsync();
            return listaClientes;
        }
    }
}