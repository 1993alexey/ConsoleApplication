import { Member } from "./members/member.model";

export class Talk {
  public talkTitle: string
  public speaker: Member
  public timeLimit: number

  constructor(speaker: Member = null, timeLimit: number = 0, talkTitle: string = "") {
    this.talkTitle = talkTitle
    this.speaker = speaker ? speaker : new Member()
    this.timeLimit = timeLimit
  }
}
