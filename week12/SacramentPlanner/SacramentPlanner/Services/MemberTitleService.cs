using System;
using System.Collections.Generic;
using MongoDB.Driver;
using SacramentPlanner.Models;

namespace SacramentPlanner.Services
{
    public class MemberTitleService
    {
        private readonly IMongoCollection<MemberTitleModel> _titles;

        public MemberTitleService(ISacramentDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _titles = database.GetCollection<MemberTitleModel>(settings.TitlesCollectionName);
        }

        public List<MemberTitleModel> Get() =>
            _titles.Find(title => true).ToList();

        public MemberTitleModel Get(string id) =>
            _titles.Find(title => title.Id == id).FirstOrDefault();

        public MemberTitleModel Create(MemberTitleModel title)
        {
            _titles.InsertOne(title);
            return title;
        }

        public void Update(string id, MemberTitleModel titleIn) =>
            _titles.ReplaceOne(title => title.Id == id, titleIn);

        public void Delete(MemberTitleModel titleIn) =>
            _titles.DeleteOne(title => title.Id == titleIn.Id);

        public void Delete(string id) =>
            _titles.DeleteOne(title => title.Id == id);
    }
}
