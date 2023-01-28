using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Biblioteca.Libro.Dominio.Entidades
{

        [BsonIgnoreExtraElements]
        public class Libro
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string _id { get; set; }
            public int idLibro { get; set; }
            public string nomLibro { get; set; }
            public string fPublicacio { get; set; }
            public int stock { get; set; }
            public string estLibro { get; set; }
        }
 }

