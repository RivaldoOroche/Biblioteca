using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using Biblioteca.Gateway.Aplicacion;


namespace Biblioteca.Gateway.Aplicacion
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            #region Mongo

           
            #endregion

            #region Servicios

            //services.AddScoped<IGatewayService, GatewayService>();

            #endregion

            return services;
        }

    }
}