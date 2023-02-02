namespace Biblioteca.Prestamo.Api.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        //asdasdas
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


    }
}
