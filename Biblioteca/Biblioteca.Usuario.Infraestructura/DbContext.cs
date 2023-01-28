using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Release.MongoDB.Repository;
using MongoDB.Driver;

namespace Biblioteca.Cliente.Infraestructura
{
    public class DbContext : DataContext, IDbContext
    {
        public DbContext(MongoUrl mongoUrl) : base(mongoUrl)
        {
        }
    }
}
