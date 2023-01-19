using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Biblioteca.Cliente.Dominio.Entidades
{
    [BsonIgnoreExtraElements]
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public int idCliente { get; set; }
        public string dniCliente { get; set; }
        public string nombCliente { get; set; }
        public string apeCliente { get; set; }
        public string telfCliente { get; set; }
        public string emailCliente { get; set; }
        public string direCliente { get; set; }
        public int estadoCliente { get; set; }
    }
}

