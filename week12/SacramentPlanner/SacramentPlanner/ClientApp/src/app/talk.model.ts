import { Member } from "./members/member.model";

export class Talk {
    public talkTitle: string
    public speaker: Member
    public timeLimit: number

    constructor(talkTitle: string, speaker: Member, timeLimit: number) {
        this.talkTitle = talkTitle
        this.speaker = speaker
        this.timeLimit = timeLimit
    }
}
