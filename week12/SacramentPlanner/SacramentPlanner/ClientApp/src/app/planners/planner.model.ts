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
  public wardBusiness: boolean //string
  public sacramentHymn: Hymn
  public sacramentPassing: boolean
  public talks: Talk[]
  public musicalNumber: MusicalNumber
  public closingHymn: Hymn
  public benediction: Member
  public dismissalSong: Hymn
  public sacramentDate: Date

  constructor(
    wardName: string = "",
    presiding: Member = null,
    conducting: Member = null,
    openingHymn: Hymn = null,
    invocation: Member = null,
    wardBusiness: boolean = false, // string,
    sacramentHymn: Hymn = null,
    sacramentPassing: boolean = false,
    talks: Talk[] = [],
    musicalNumber: MusicalNumber = null,
    closingHymn: Hymn = null,
    benediction: Member = null,
    dismissalSong: Hymn = null,
    sacramentDate: Date = null
  ) {

    this.wardName = wardName
    this.presiding = presiding ? presiding : new Member()
    this.conducting = conducting ? conducting : new Member()
    this.openingHymn = openingHymn ? openingHymn : new Hymn()
    this.invocation = invocation ? invocation : new Member()
    this.wardBusiness = wardBusiness
    this.sacramentHymn = sacramentHymn ? sacramentHymn : new Hymn()
    this.sacramentPassing = sacramentPassing
    this.talks = talks
    this.musicalNumber = musicalNumber ? musicalNumber : new MusicalNumber()
    this.closingHymn = closingHymn ? closingHymn : new Hymn()
    this.benediction = benediction ? benediction : new Member()
    this.dismissalSong = dismissalSong ? dismissalSong : new Hymn()
    this.sacramentDate = sacramentDate ? sacramentDate : new Date()
  }

  // get sacramentDate(): Date {
  //   return this.sacramentDate
  // }

  // set sacramentDate(sacramentDate: Date) {
  //   this.sacramentDate = sacramentDate
  // }
}
