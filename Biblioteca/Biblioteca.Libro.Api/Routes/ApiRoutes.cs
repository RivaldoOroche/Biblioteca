
namespace Biblioteca.Libro.Api.Routes
{
    
        public static class ApiRoutes
        {
            public const string Root = "api";
            public const string Version = "v1";
            public const string Base = Root + "/" + Version;

            //asdasdas
            public static class RouteLibro
            {
                //Para Leer
                public const string GetAll = Base + "/libro/all";
            public const string GetById = Base + "/libro/{id}";
                //Write
                public const string Create = Base + "/libro/create";
                public const string Update = Base + "/libro/update";
            public const string Delete = Base + "/libro/delete";
            }


        }
    
}
