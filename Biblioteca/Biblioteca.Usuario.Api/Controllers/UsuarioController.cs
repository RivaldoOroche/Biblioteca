using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Usuario.Dominio;
namespace Biblioteca.Usuario.Api.Controllers
{

    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //private ProductoQueryAll db = ProductoQueryAll();
        [HttpGet(Routes.ApiRoutes.RouteUsuario.GetAll)]
        public IEnumerable<dominio.Entidades.Usuario> ListarUsuarios()
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Usuario>("Usuario");
            #endregion

            var listaUsuario = colecction.Find(x => true).ToList();
            return listaUsuario;
        }
        [HttpGet(Routes.ApiRoutes.RouteUsuario.GetById)]
        public dominio.Entidades.Usuario BuscarUsuario(int id)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Usuario>("Usuario");
            #endregion

            var objUsuario = colecction.Find(x => x.idUsuario == id).FirstOrDefault();
            return objUsuario;
        }

        [HttpPost(Routes.ApiRoutes.RouteUsuario.Create)]
        public ActionResult<dominio.Entidades.Usuario> CrearUsuario(dominio.Entidades.Usuario Usuario)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Usuario>("Usuario");
            #endregion

            Usuario._id = ObjectId.GenerateNewId().ToString();
            colecction.InsertOne(Usuario);
            return Ok();
        }
        [HttpPut(Routes.ApiRoutes.RouteUsuario.Update)]
        public ActionResult<dominio.Entidades.Usuario> ModificarUsuario(dominio.Entidades.Usuario Usuario)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Usuario>("Usuario");
            #endregion
            colecction.FindOneAndReplace(x => x._id == Usuario._id, Usuario);
            return Ok();
        }
        [HttpDelete(Routes.ApiRoutes.RouteUsuario.Delete)]
        public ActionResult<dominio.Entidades.Usuario> EliminarUsuario(int id)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Usuario>("Usuario");
            #endregion

            colecction.FindOneAndDelete(x => x.idUsuario == id);
            return Ok();
        }
    }
}
    
