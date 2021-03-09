using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace BooksApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [Key]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}