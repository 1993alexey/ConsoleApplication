using System;
using System.Collections.Generic;
using MongoDB.Driver;
using SacramentPlanner.Models;

namespace SacramentPlanner.Services
{
    public class HymnService
    {
        private readonly IMongoCollection<HymnModel> _hymns;

        public HymnService(ISacramentDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _hymns = database.GetCollection<HymnModel>(settings.HymnsCollectionName);
        }

        public List<HymnModel> Get() =>
            _hymns.Find(hymn => true).ToList();

        public HymnModel Get(string id) =>
            _hymns.Find(hymn => hymn.Id == id).FirstOrDefault();

        public HymnModel Create(HymnModel hymn)
        {
            _hymns.InsertOne(hymn);
            return hymn;
        }

        public void Update(HymnModel hymnIn) =>
            _hymns.ReplaceOne(hymn => hymn.Id == hymnIn.Id, hymnIn);

        public void Delete(HymnModel hymnIn) =>
            _hymns.DeleteOne(hymn => hymn.Id == hymnIn.Id);

        public void Delete(string id) =>
            _hymns.DeleteOne(hymn => hymn.Id == id);
    }
}
