using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using dominio = Biblioteca.Usuario.Dominio.Entidades;
using static Biblioteca.Usuario.Api.Routes.ApiRoutes;
using Biblioteca.Usuario.Aplicacion.Usuario;

[ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet(RouteUsuario.GetAll)]
        public IEnumerable<dominio.Usuario> ListarUsuarios()
        {

            var listaUsuario = _service.ListarUsuarios();
            return listaUsuario;
        }

        [HttpGet(RouteUsuario.GetById)]
        public dominio.Usuario BuscarUsuario(int id)
        {
            var objUsuario = _service.Usuario(id);

            return objUsuario;
        }

        [HttpPost(RouteUsuario.Create)]
        public ActionResult<dominio.Usuario> CrearUsuario([FromBody] dominio.Usuario Usuario)
        {
            _service.RegistrarUsuario(Usuario);

            return Ok();
        }

        [HttpDelete(RouteUsuario.Delete)]
        public ActionResult<dominio.Usuario> EliminarUsuario(int id)
        {
            _service.Eliminar(id);

            return Ok(id);
        }
    }

    
