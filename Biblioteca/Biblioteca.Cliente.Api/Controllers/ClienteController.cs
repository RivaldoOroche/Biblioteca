using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Cliente.Dominio.Entidades;
using static Biblioteca.Cliente.Api.Routes.ApiRoutes;
using Biblioteca.Cliente.Aplicacion.Cliente;

namespace Biblioteca.Cliente.Api.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet(RouteCliente.GetAll)]
        public IEnumerable<dominio.Cliente> ListarClientes()
        {

            var listaCliente = _service.ListarClientes();
            return listaCliente;
        }

        [HttpGet(RouteCliente.GetById)]
        public dominio.Cliente BuscarCliente(int id)
        {
            var objCliente = _service.Cliente(id);

            return objCliente;
        }

        [HttpPost(RouteCliente.Create)]
        public ActionResult<dominio.Cliente> CrearCliente([FromBody] dominio.Cliente cliente)
        {
            _service.RegistrarCliente(cliente);

            return Ok();
        }

        [HttpDelete(RouteCliente.Delete)]
        public ActionResult<dominio.Cliente> EliminarCliente(int id)
        {
            _service.Eliminar(id);

            return Ok(id);
        }
    }
}
