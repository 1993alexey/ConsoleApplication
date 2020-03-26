using System;
namespace SacramentPlanner.Models
{
    public class MusicalNumberModel
	{
		public string Title { get; set; }
        public int PerformAfterTalk { get; set; }

        public MusicalNumberModel(string title, int afterTalk)
        {
            Title = title;
            PerformAfterTalk = afterTalk;
        }
    }
}
