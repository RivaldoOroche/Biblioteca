namespace Biblioteca.Gateway.Api.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        //asdasdas
        public static class RouteCliente
        {
            //Para Leer
            public const string GetAll = Base + "/cliente/all";
            public const string GetById = Base + "/cliente/{id}";

            //Write
            public const string Create = Base + "/cliente/create";
            public const string Update = Base + "/cliente/update";
            public const string Delete = Base + "/cliente/delete";
     
        }

        public static class RouteAutor
        {
            //Para Leer
            public const string GetAll = Base + "/autor/all";
            public const string GetById = Base + "/autor/{id}";

            //Write
            public const string Create = Base + "/autor/create";
            public const string Update = Base + "/autor/update";
            public const string Delete = Base + "/autor/delete";

        }
        public static class RoutePrestamo
        {
            //Para Leer
            public const string GetAll = Base + "/prestamo/all";
            public const string GetById = Base + "/prestamo/{id}";

            //Write
            public const string Create = Base + "/prestamo/create";
            public const string Update = Base + "/prestamo/update";
            public const string Delete = Base + "/prestamo/delete";

        }
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
        public static class RouteUsuario
        {
            //Para Leer
            public const string GetAll = Base + "/usuario/all";
            public const string GetById = Base + "/usuario/{id}";

            //Write
            public const string Create = Base + "/usuario/create";
            public const string Update = Base + "/usuario/update";
            public const string Delete = Base + "/usuario/delete";

        }
    }
   
}
