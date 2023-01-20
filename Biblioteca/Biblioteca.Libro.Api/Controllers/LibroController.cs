using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Libro.Dominio;

namespace Biblioteca.Libro.Api.Controllers
{

    [ApiController]
    public class LibroController : ControllerBase
    {
        //private ProductoQueryAll db = ProductoQueryAll();
        [HttpGet(Routes.ApiRoutes.RouteLibro.GetAll)]
        public IEnumerable<dominio.Entidades.Libro> ListarLibros()
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Libro>("Libro");
            #endregion

            var listaLibro = colecction.Find(x => true).ToList();
            return listaLibro;
        }
        [HttpGet(Routes.ApiRoutes.RouteLibro.GetById)]
        public dominio.Entidades.Libro BuscarLibro(int id)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Libro>("Libro");
            #endregion

            var objLibro = colecction.Find(x => x.idLibro == id).FirstOrDefault();
            return objLibro;
        }

        [HttpPost(Routes.ApiRoutes.RouteLibro.Create)]
        public ActionResult<dominio.Entidades.Libro> CrearLibro(dominio.Entidades.Libro Libro)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Libro>("Libro");
            #endregion

            Libro._id = ObjectId.GenerateNewId().ToString();
            colecction.InsertOne(Libro);
            return Ok();
        }
        [HttpPut(Routes.ApiRoutes.RouteLibro.Update)]
        public ActionResult<dominio.Entidades.Libro> ModificarLibro(dominio.Entidades.Libro Libro)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Libro>("Libro");
            #endregion
            colecction.FindOneAndReplace(x => x._id == Libro._id, Libro);
            return Ok();
        }
        [HttpDelete(Routes.ApiRoutes.RouteLibro.Delete)]
        public ActionResult<dominio.Entidades.Libro> EliminarLibro(int id)
        {
            #region
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("biblioteca");
            var colecction = database.GetCollection<dominio.Entidades.Libro>("Libro");
            #endregion

            colecction.FindOneAndDelete(x => x.idLibro == id);
            return Ok();
        }
    }
}
