using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Release.MongoDB.Repository;
using MongoDB.Driver;

namespace Biblioteca.Usuario.Infraestructura
{
    public class DbContext : DataContext, IDbContext
    {
        public DbContext(MongoUrl mongoUrl) : base(mongoUrl)
        {
        }
    }
}
