using System;
namespace SacramentPlanner.Models
{
    public class SacramentDatabaseSettings : ISacramentDatabaseSettings
    {
        public string PlannerCollectionName { get; set; }
        public string MembersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISacramentDatabaseSettings
    {
        string PlannerCollectionName { get; set; }
        string MembersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
