import { Member } from "../members/member.model";
import { Hymn } from "../hymns/hymn.model";
import { Talk } from "../talk.model";
import { MusicalNumber } from "../musicalNumber.model";


export class Planner {
    public id: string
    public wardName: string
    public presiding: Member
    public conducting: Member
    public openingHymn: Hymn
    public invocation: Member
    public wardBusiness: string
    public sacramentHymn: Hymn
    public sacramentPassing: boolean
    public Talks: Talk[]
    public musicalNumber: MusicalNumber
    public closingHymn: Hymn
    public benediction: Member
    public dismissalSong: Hymn
    public sacramentDate: Date //???

    constructor(
        wardName: string,
        presiding: Member,
        conducting: Member,
        openingHymn: Hymn,
        invocation: Member,
        wardBusiness: string,
        sacramentHymn: Hymn,
        sacramentPassing: boolean,
        Talks: Talk[],
        musicalNumber: MusicalNumber,
        closingHymn: Hymn,
        benediction: Member,
        dismissalSong: Hymn,
        sacramentDate: Date
    ) {
        this.wardName = wardName
        this.presiding = presiding
        this.conducting = conducting
        this.openingHymn = openingHymn
        this.invocation = invocation
        this.wardBusiness = wardBusiness
        this.sacramentHymn = sacramentHymn
        this.sacramentPassing = sacramentPassing
        this.Talks = Talks
        this.musicalNumber = musicalNumber
        this.closingHymn = closingHymn
        this.benediction = benediction
        this.dismissalSong = dismissalSong
        this.sacramentDate = sacramentDate
    }
}