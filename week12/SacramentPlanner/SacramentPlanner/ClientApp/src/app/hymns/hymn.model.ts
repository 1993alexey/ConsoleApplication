export class Hymn {
  public id: string
  public title: string
  public hymnNumber: number

  constructor(hymnNumber?: number, title: string = "") {
    this.hymnNumber = hymnNumber
    this.title = title
  }
}
