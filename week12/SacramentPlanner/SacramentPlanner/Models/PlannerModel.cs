using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SacramentPlanner.Models
{
    public class PlannerModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
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

        public PlannerModel(
            string wardName,
            MemberModel presiding,
            MemberModel conducting,
            HymnModel openingHymn,
            MemberModel invocation,
            bool wardBusiness,
            HymnModel sacramentHymn,
            bool sacramentPassing,
            List<TalkModel> talks,
            MusicalNumberModel musicalNumber,
            HymnModel closingHymn,
            MemberModel benediction,
            HymnModel dismissalSong,
            DateTime sacramentDate)
        {
            WardName = wardName;
            Presiding = presiding;
            Conducting = conducting;
            OpeningHymn = openingHymn;
            Invocation = invocation;
            WardBusiness = wardBusiness;
            SacramentHymn = sacramentHymn;
            SacramentPassing = SacramentPassing;
            Talks = talks;
            MusicalNumber = musicalNumber;
            ClosingHymn = closingHymn;
            Benediction = benediction;
            DismissalSong = dismissalSong;
            SacramentDate = sacramentDate;
        }

        public PlannerModel() { }
    }
}
