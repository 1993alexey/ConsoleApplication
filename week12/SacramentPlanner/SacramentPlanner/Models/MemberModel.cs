using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SacramentPlanner.Models
{
    public class MemberModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberTitle { get; set; }

        public MemberModel(string firstName, string lastName, string memberTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            MemberTitle = memberTitle;
        }

        public MemberModel() {}
    }
}
