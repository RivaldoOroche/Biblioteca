using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Biblioteca.Usuario.Dominio.Entidades
{

    [BsonIgnoreExtraElements]
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public int idUsuario { get; set; }
        public string dniUsuario { get; set; }
        public string nombUsuario { get; set; }
        public string apeUsuario { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string estUsu { get; set; }
     }
}

