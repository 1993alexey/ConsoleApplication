using System;
namespace SacramentPlanner.Models
{
    public class SacramentDatabaseSettings : ISacramentDatabaseSettings
    {
        public string PlannerCollectionName { get; set; }
        public string MembersCollectionName { get; set; }
        public string TitlesCollectionName { get; set; }
        public string HymnsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISacramentDatabaseSettings
    {
        string PlannerCollectionName { get; set; }
        string MembersCollectionName { get; set; }
        string TitlesCollectionName { get; set; }
        string HymnsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
