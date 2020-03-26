using System;
using System.Collections.Generic;
using MongoDB.Driver;
using SacramentPlanner.Models;

namespace SacramentPlanner.Services
{
    public class PlannerService
    {

        private readonly IMongoCollection<PlannerModel> _planner;

        public PlannerService(ISacramentDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _planner = database.GetCollection<PlannerModel>(settings.PlannerCollectionName);
        }

        public List<PlannerModel> Get() =>
            _planner.Find(planner => true).ToList();

        public PlannerModel Get(string id) =>
            _planner.Find(planner => planner.Id == id).FirstOrDefault();

        public PlannerModel Create(PlannerModel planner)
        {
            _planner.InsertOne(planner);
            return planner;
        }

        public void Update(string id, PlannerModel plannerIn) =>
            _planner.ReplaceOne(planner => planner.Id == id, plannerIn);

        public void Delete(PlannerModel plannerIn) =>
            _planner.DeleteOne(planner => planner.Id == plannerIn.Id);

        public void Delete(string id) =>
            _planner.DeleteOne(planner => planner.Id == id);
    }
}
