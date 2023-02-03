using Biblioteca.Prestamo.Infraestructura;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using Biblioteca.Prestamo.Aplicacion.Prestamo;
using dominio = Biblioteca.Prestamo.Dominio.Entidades;

namespace Biblioteca.Prestamo.Aplicacion
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            #region Mongo

            string cs = configuration.GetSection("DBSettings:ConnectionString").Value;
            var dbUrl = new MongoUrl(cs);

            services.AddScoped<IDbContext>(x => new DbContext(dbUrl));

            //Entidades            
            services.TryAddScoped<ICollectionContext<dominio.Prestamo>>(x => new CollectionContext<dominio.Prestamo>(x.GetService<IDbContext>()));

            //Como Repo
            services.TryAddScoped<IBaseRepository<dominio.Prestamo>>(x => new BaseRepository<dominio.Prestamo>(x.GetService<IDbContext>()));

            #endregion

            #region Servicios

            services.AddScoped<IPrestamoService, PrestamoService>();

            #endregion

            return services;
        }

    }
}