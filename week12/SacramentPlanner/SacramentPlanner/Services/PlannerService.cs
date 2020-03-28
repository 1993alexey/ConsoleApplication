using System;
using System.Collections.Generic;
using MongoDB.Driver;
using SacramentPlanner.Models;

namespace SacramentPlanner.Services
{
    public class PlannerService
    {

        private readonly IMongoCollection<PlannerModel> _planners;

        public PlannerService(ISacramentDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _planners = database.GetCollection<PlannerModel>(settings.PlannerCollectionName);
        }

        public List<PlannerModel> Get() =>
            _planners.Find(planner => true).ToList();

        public PlannerModel Get(string id) =>
            _planners.Find(planner => planner.Id == id).FirstOrDefault();

        public PlannerModel Create(PlannerModel planner)
        {
            _planners.InsertOne(planner);
            return planner;
        }

        public void Update(string id, PlannerModel plannerIn) =>
            _planners.ReplaceOne(planner => planner.Id == id, plannerIn);

        public void Delete(PlannerModel plannerIn) =>
            _planners.DeleteOne(planner => planner.Id == plannerIn.Id);

        public void Delete(string id) =>
            _planners.DeleteOne(planner => planner.Id == id);
    }
}
