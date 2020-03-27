using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SacramentPlanner.Models
{
    public class HymnModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }
        public int HymnNumber { get; set; }

        public HymnModel(string title, int number)
        {
            Title = title;
            HymnNumber = number;
        }

        public HymnModel(){}
    }
}
