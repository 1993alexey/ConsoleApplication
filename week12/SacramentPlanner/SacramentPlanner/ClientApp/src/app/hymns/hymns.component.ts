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
  oneHymn = new Hymn()
  editMode = false

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

  edit() {
    this.hymnsService.updateHymn(this.oneHymn).subscribe()
    // for (let hymn of this.hymns) {
    //   if (hymn.id == this.oneHymn.id) {
    //     hymn = this.oneHymn
    //     break
    //   }
    // }

    // this.oneHymn = null
  }

  showModal(hymn: Hymn) {
    if (!hymn)
      this.oneHymn = new Hymn()
    else
      this.oneHymn = hymn

    this.editMode = hymn ? true : false
    $("#hymn-modal").modal("show");
  }

  delete(id: string) {
    this.hymns = this.hymns.filter(hymn => hymn.id != id)
    this.hymnsService.deleteHymn(id).subscribe()
  }

  sortHymns() {
    this.hymns.sort(((a, b) => a.hymnNumber - b.hymnNumber))
  }

  hideModal() {
    this.oneHymn = new Hymn()
    this.hymnNumberInput.nativeElement.value = ''
    this.hymnTitleInput.nativeElement.value = ''
    $("#hymn-modal").modal("hide");
  }
}
