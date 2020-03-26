using System;
using System.Collections.Generic;
using MongoDB.Driver;
using SacramentPlanner.Models;

namespace SacramentPlanner.Services
{
    public class MemberService
    {
        private readonly IMongoCollection<MemberModel> _members;

        public MemberService(ISacramentDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _members = database.GetCollection<MemberModel>(settings.MembersCollectionName);
        }

        public List<MemberModel> Get() =>
            _members.Find(member => true).ToList();

        public MemberModel Get(string id) =>
            _members.Find(member => member.Id == id).FirstOrDefault();

        public MemberModel Create(MemberModel member)
        {
            _members.InsertOne(member);
            return member;
        }

        public void Update(string id, MemberModel memberIn) =>
            _members.ReplaceOne(member => member.Id == id, memberIn);

        public void Delete(MemberModel memberIn) =>
            _members.DeleteOne(member => member.Id == memberIn.Id);

        public void Delete(string id) =>
            _members.DeleteOne(member => member.Id == id);
    }
}
