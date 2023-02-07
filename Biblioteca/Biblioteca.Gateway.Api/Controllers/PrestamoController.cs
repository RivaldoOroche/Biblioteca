using Microsoft.AspNetCore.Mvc;
using Prestamos = Biblioteca.Gateway.Aplicacion.PrestamoClient;
using static Biblioteca.Gateway.Api.Routes.ApiRoutes;

namespace Biblioteca.Gateway.Api.Controllers
{
    public class PrestamoController : ControllerBase
    {

        private readonly Prestamos.IClient _client;

        public PrestamoController(Prestamos.IClient client)
        {
            _client = client;
        }

        [HttpGet(RoutePrestamo.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public Task<ICollection<Prestamos.Prestamo>> ListarPrestamo()
        {
            var listaPrestamos = _client.ApiV1PrestamoAllAsync();
            return listaPrestamos;
        }
    }
}
