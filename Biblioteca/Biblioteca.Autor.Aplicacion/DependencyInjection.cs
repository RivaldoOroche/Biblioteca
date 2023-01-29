using Biblioteca.Autor.Infraestructura;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using Biblioteca.Autor.Aplicacion.Autor;
using dominio = Biblioteca.Autor.Dominio.Entidades;

namespace Biblioteca.Autor.Aplicacion
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
            services.TryAddScoped<ICollectionContext<dominio.Autor>>(x => new CollectionContext<dominio.Autor>(x.GetService<IDbContext>()));

            //Como Repo
            services.TryAddScoped<IBaseRepository<dominio.Autor>>(x => new BaseRepository<dominio.Autor>(x.GetService<IDbContext>()));

            #endregion

            #region Servicios

            services.AddScoped<IAutorService, AutorService>();

            #endregion

            return services;
        }

    }
}