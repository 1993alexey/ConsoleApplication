import { Member } from "../members/member.model";
import { Hymn } from "../hymns/hymn.model";
import { Talk } from "../talk.model";
import { MusicalNumber } from "../musicalNumber.model";


export class Planners {
    constructor(

        // TO DELETE

        // public string Id { get; set; }                           DONE
        // public string WardName { get; set; }                     DONE
        // public MemberModel Presiding { get; set; }               DONE
        // public MemberModel Conducting { get; set; }              DONE
        // public HymnModel OpeningHymn { get; set; }               DONE
        // public MemberModel Invocation { get; set; }              DONE
        // public bool WardBusiness { get; set; }                   DONE
        // public HymnModel SacramentHymn { get; set; }             DONE
        // public bool SacramentPassing { get; set; }               DONE
        // public List<TalkModel> Talks { get; set; }               DONE
        // public MusicalNumberModel MusicalNumber { get; set; }    DONE
        // public HymnModel ClosingHymn { get; set; }               DONE
        // public MemberModel Benediction { get; set; }             DONE
        // public HymnModel DismissalSong { get; set; }             Done
        // public DateTime SacramentDate { get; set; }              DONE

        public id: string,
        public wardName: string,
        public presiding: Member,
        public conducting: Member,
        public openingHymn: Hymn,
        public invocation: Member,
        public wardBusiness: string,
        public sacramentHymn: Hymn,
        public sacramentPassing: boolean,
        public Talks: Talk[],
        public musicalNumber: MusicalNumber,
        public closingHymn: Hymn,
        public benediction: Member,
        public dismissalSong: Hymn,
        public sacramentDate: string
    ) { }
}