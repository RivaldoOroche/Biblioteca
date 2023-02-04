﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using Biblioteca.Gateway.Aplicacion;
using Biblioteca.Gateway.Aplicacion.Common;



namespace Biblioteca.Gateway.Aplicacion
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddClientes(configuration);

            return services;


        }
        public static IServiceCollection AddClientes(this IServiceCollection services, IConfiguration configuration)
        {
            //CLIENT_SETTINGS
            var msSettings = new ClientSettings();
            configuration.Bind(nameof(ClientSettings), msSettings);

            #region Cliente Ms Clientes

            services.AddHttpClient("MsClientes", client =>
            {
                client.BaseAddress = new Uri(msSettings.ClienteUrl);
            });

            #endregion
            #region Autor Ms Autors

            services.AddHttpClient("MsAutor", client =>
            {
                client.BaseAddress = new Uri(msSettings.AutorUrl);
            });

            #endregion
            #region Libro Ms Libros

            services.AddHttpClient("MsLibro", client =>
            {
                client.BaseAddress = new Uri(msSettings.LibroUrl);
            });

            #endregion

            services.AddTransient<ClientesClient.IClient, ClientesClient.Client>();
            services.AddTransient<AutorClient.IClient, AutorClient.Client>();
            services.AddTransient<LibroClient.IClient, LibroClient.Client>();


            return services;
        }
    }
}