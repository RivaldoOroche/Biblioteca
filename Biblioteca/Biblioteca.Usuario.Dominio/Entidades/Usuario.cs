using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Release.MongoDB.Repository;
using Release.MongoDB.Repository.Model;

namespace Biblioteca.Usuario.Dominio.Entidades
{
    [CollectionProperty("usuario")]
    [BsonIgnoreExtraElements]
    public class Usuario : EntityToLower<ObjectId>
    {   
        public int idUsuario { get; set; }
        public string dniUsuario { get; set; }
        public string nombUsuario { get; set; }
        public string apeUsuario { get; set; }
        public string login { get; set; }
        public string password { get; set; }
     }
}

