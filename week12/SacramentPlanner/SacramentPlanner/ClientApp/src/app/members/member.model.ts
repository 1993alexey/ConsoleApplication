export class Member {
  public id: string
  public firstName: string
  public lastName: string
  public memberTitle: string

  constructor(firstName: string = "", lastName: string = "", memberTitle: string = "") {
    this.firstName = firstName
    this.lastName = lastName
    this.memberTitle = memberTitle
  }
}
