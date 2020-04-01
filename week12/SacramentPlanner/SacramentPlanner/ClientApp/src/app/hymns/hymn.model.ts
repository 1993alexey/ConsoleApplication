export class Hymn {
  public id: string
  public title: string
  public hymnNumber: number

  constructor(hymnNumber: number = 0, title: string = "") {
    this.hymnNumber = hymnNumber
    this.title = title
  }
}
