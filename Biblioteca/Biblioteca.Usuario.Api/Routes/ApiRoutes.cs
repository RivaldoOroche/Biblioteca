namespace Biblioteca.Usuario.Api.Routes
{
  
        public static class ApiRoutes
        {
            public const string Root = "api";
            public const string Version = "v1";
            public const string Base = Root + "/" + Version;

            //asdasdas
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


