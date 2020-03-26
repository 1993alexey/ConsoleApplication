using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SacramentPlanner.Models
{
    public class MemberTitleModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }

        public MemberTitleModel() { }

        public MemberTitleModel(string titleName)
        {
            Title = titleName;
        }
    }
}
