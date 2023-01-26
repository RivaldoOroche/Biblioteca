using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Release.MongoDB.Repository;
using Release.MongoDB.Repository.Model;

namespace Biblioteca.Cliente.Dominio.Entidades
{
    [CollectionProperty("cliente")]
    [BsonIgnoreExtraElements]
    public class Cliente :EntityToLower<ObjectId>
    {
     
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

