using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Release.MongoDB.Repository;
using Release.MongoDB.Repository.Model;

namespace Biblioteca.Autor.Dominio.Entidades
{
    [CollectionProperty("autor_libro")]
    [BsonIgnoreExtraElements]
    public class Autor_Libro : EntityToLower<ObjectId>
    {
        public int idAutor { get; set; }
        public int idLibro { get; set; }
        //public string dniCliente { get; set; }
        //public string nombAutor { get; set; }
        //public string apeAutor { get; set; }
        //public string telfCliente { get; set; }
        //public string emailCliente { get; set; }
        //public DateTime fnaciAutor { get; set; }

    }
}

