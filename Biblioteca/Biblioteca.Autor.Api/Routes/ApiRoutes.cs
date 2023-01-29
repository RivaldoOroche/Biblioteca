namespace Biblioteca.Autor.Api.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        //asdasdas
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


    }
}
