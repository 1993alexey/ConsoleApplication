import { Component, OnInit, ViewChild } from '@angular/core';
import { HymnService } from './hymn.service';
import { Hymn } from './hymn.model';
import { faTrashAlt, faEdit } from '@fortawesome/free-solid-svg-icons';
declare var $: any;

@Component({
  selector: 'app-hymns',
  templateUrl: './hymns.component.html',
  styleUrls: ['./hymns.component.css']
})
export class HymnsComponent implements OnInit {
  @ViewChild('hymnNumber', { static: true }) hymnNumberInput: any;
  @ViewChild('hymnTitle', { static: true }) hymnTitleInput: any;

  faTrashAlt = faTrashAlt
  faEdit = faEdit
  public hymns: Hymn[]
  hymn: Hymn
  id: string

  constructor(private hymnsService: HymnService) { }

  ngOnInit() {
    this.hymnsService.getHymns().subscribe(hymns => {
      this.hymns = hymns
      this.sortHymns()
    })
  }

  create(hymn: Hymn) {
    if (typeof hymn.hymnNumber === 'string')
      hymn.hymnNumber = parseInt(hymn.hymnNumber)

    this.hymnsService.addHymn(hymn)
      .subscribe(newHymn => {
        this.hymns.push(newHymn)
        this.sortHymns()
      })

    this.hymnsService.getHymns().subscribe(hymns => this.hymns = hymns)
  }

  // updateDocument() {
  //   const newHymn = new Hymn(this.hymn.hymnNumber, this.hymn.title);
  //   this.hymnsService.updateHymn(this.hymn, newHymn);
  // }


  delete(id: string) {
    this.hymns = this.hymns.filter(hymn => hymn.id != id)
    this.hymnsService.deleteHymn(id).subscribe()
  }

  sortHymns() {
    this.hymns.sort(((a, b) => a.hymnNumber - b.hymnNumber))
  }

  hideModal() {
    this.hymnNumberInput.nativeElement.value = ''
    this.hymnTitleInput.nativeElement.value = ''
    $("#hymn-modal").modal("hide");
  }

  getId(id: string) {
    this.id = id;
    this.hymnsService.getHymn(id).subscribe(hymn => this.hymn = hymn)
  }
}
