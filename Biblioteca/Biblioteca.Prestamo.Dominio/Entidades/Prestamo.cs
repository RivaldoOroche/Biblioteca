using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Release.MongoDB.Repository;
using Release.MongoDB.Repository.Model;

namespace Biblioteca.Prestamo.Dominio.Entidades
{
    [CollectionProperty("prestamo")]
    [BsonIgnoreExtraElements]
    public class Prestamo : EntityToLower<ObjectId>
    {
        public int idPrestamo { get; set; }
        public string fPrestamo { get; set; }
        public string fDevolucion { get; set; } 
     
    }
}

