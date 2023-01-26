using Biblioteca.Cliente.Infraestructura;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using Biblioteca.Cliente.Aplicacion.Cliente;
using Biblioteca.Cliente.Infraestructura;
using dominio = Biblioteca.Cliente.Dominio.Entidades;

namespace Biblioteca.Cliente.Aplicacion
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
            services.TryAddScoped<ICollectionContext<dominio.Cliente>>(x => new CollectionContext<dominio.Cliente>(x.GetService<IDbContext>()));
            //services.TryAddScoped<ICollectionContext<dominio.Categoria>>(x => new CollectionContext<dominio.Categoria>(x.GetService<IDbContext>()));

            //Como Repo
            services.TryAddScoped<IBaseRepository<dominio.Cliente>>(x => new BaseRepository<dominio.Cliente>(x.GetService<IDbContext>()));
            //services.TryAddScoped<IBaseRepository<dominio.Categoria>>(x => new BaseRepository<dominio.Categoria>(x.GetService<IDbContext>()));

            #endregion

            #region Servicios

            services.AddScoped<IClienteService, ClienteService>();
            //services.AddScoped<ICategoriaService, CategoriaService>();

            #endregion

            return services;
        }

    }
}