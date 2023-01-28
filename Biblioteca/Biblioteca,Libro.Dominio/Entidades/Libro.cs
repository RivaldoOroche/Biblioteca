using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Release.MongoDB.Repository;
using Release.MongoDB.Repository.Model;

namespace Biblioteca.Libro.Dominio.Entidades
{

    [CollectionProperty("libro")]
    [BsonIgnoreExtraElements]
    public class Libro: EntityToLower<ObjectId>
    {
            public int idLibro { get; set; }
            public string nomLibro { get; set; }
            public string fPublicacio { get; set; }
            public int stock { get; set; }
        }
 }

