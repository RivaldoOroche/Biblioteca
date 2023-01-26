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

        //private ProductoQueryAll db = ProductoQueryAll();
        /*[HttpGet(Routes.ApiRoutes.RouteCliente.GetAll)]
        public IEnumerable<dominio.Entidades.Cliente> ListarClientes()
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Cliente>("cliente");
            #endregion

            var listaCliente = colecction.Find(x => true).ToList();
            return listaCliente;
        }
        [HttpGet(Routes.ApiRoutes.RouteCliente.GetById)]
        public dominio.Entidades.Cliente BuscarCliente(int id)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Cliente>("cliente");
            #endregion

            var objCliente = colecction.Find(x => x.idCliente == id).FirstOrDefault();
            return objCliente;
        }

        [HttpPost(Routes.ApiRoutes.RouteCliente.Create)]
        public ActionResult<dominio.Entidades.Cliente> CrearCliente(dominio.Entidades.Cliente cliente)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Cliente>("cliente");
            #endregion

            cliente._id = ObjectId.GenerateNewId().ToString();
            colecction.InsertOne(cliente);
            return Ok();
        }
        [HttpPut(Routes.ApiRoutes.RouteCliente.Update)]
        public ActionResult<dominio.Entidades.Cliente> ModificarCliente(dominio.Entidades.Cliente cliente)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Cliente>("cliente");
            #endregion
            colecction.FindOneAndReplace(x => x._id == cliente._id, cliente);
            return Ok();
        }
        [HttpDelete(Routes.ApiRoutes.RouteCliente.Delete)]
        public ActionResult<dominio.Entidades.Cliente> EliminarCliente(int id)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Cliente>("cliente");
            #endregion

            colecction.FindOneAndDelete(x => x.idCliente == id);
            return Ok();
        }*/
        [HttpGet(RouteCliente.GetAll)]
        public IEnumerable<dominio.Cliente> ListarClientes()
        {
            var listaCliente = _service.ListarClientes();return listaCliente;
        }
        [HttpGet(RouteCliente.GetById)]
        public dominio.Cliente BuscarCliente(int id) 
        {
            var objCliente = _service.Cliente(id);return objCliente;
        }
        [HttpPost(RouteCliente.Create)]
        public ActionResult<dominio.Cliente> CrearCliente([FromBody]dominio.Cliente cliente)
        {
            _service.RegistrarCliente(cliente);return Ok();
        }
        [HttpDelete(RouteCliente.Delete)]
        public ActionResult<dominio.Cliente> EliminarCliente(int id) 
        {
            _service.Eliminar(id); return Ok();
        }
    }
}
