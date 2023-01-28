using Biblioteca.Libro.Infraestructura;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using Biblioteca.Libro.Aplicacion.Libro;
using dominio = Biblioteca.Libro.Dominio.Entidades;

namespace Biblioteca.Libro.Aplicacion
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
            services.TryAddScoped<ICollectionContext<dominio.Libro>>(x => new CollectionContext<dominio.Libro>(x.GetService<IDbContext>()));

            //Como Repo
            services.TryAddScoped<IBaseRepository<dominio.Libro>>(x => new BaseRepository<dominio.Libro>(x.GetService<IDbContext>()));

            #endregion

            #region Servicios

            services.AddScoped<ILibroService, LibroService>();

            #endregion

            return services;
        }

    }
}