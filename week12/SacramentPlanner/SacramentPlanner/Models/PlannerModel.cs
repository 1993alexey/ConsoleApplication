using System;
using System.Collections.Generic;

namespace SacramentPlanner.Models
{
    public class PlannerModel
    {
        public string Id { get; set; }
        public string WardName { get; set; }
        public MemberModel Presiding { get; set; }
        public MemberModel Conducting { get; set; }
        public HymnModel OpeningHymn { get; set; }
        public MemberModel Invocation { get; set; }
        public bool WardBusiness { get; set; }
        public HymnModel SacramentHymn { get; set; }
        public bool SacramentPassing { get; set; }
        public List<TalkModel> Talks { get; set; }
        public MusicalNumberModel MusicalNumber { get; set; }
        public HymnModel ClosingHymn { get; set; }
        public MemberModel Benediction { get; set; }
        public HymnModel DismissalSong { get; set; }
        public DateTime SacramentDate { get; set; }
    }
}
