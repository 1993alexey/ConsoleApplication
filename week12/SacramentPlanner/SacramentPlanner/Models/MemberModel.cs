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
        public MemberTitleModel MemberTitle { get; set; }

        public MemberModel(string firstName, string lastName, MemberTitleModel memberTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            MemberTitle = memberTitle;
        }
    }
}
