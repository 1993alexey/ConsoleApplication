import { Component, OnInit } from '@angular/core';
import { HymnService } from '../services/hymn.service';
import { Hymn } from '../models/hymn.model';
import { faTrashAlt, faEdit } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-hymns',
  templateUrl: './hymns.component.html',
  styleUrls: ['./hymns.component.css']
})
export class HymnsComponent implements OnInit {

  faTrashAlt = faTrashAlt
  faEdit = faEdit
  public hymns: Hymn[]

  constructor(private hymnsService: HymnService) { }

  ngOnInit() {
    this.hymnsService.getHymns().subscribe(hymns => {
      this.hymns = hymns
      this.sortHymns()
    })
  }

  create(hymn: Hymn) {
    this.hymnsService.addHymn(hymn)
      .subscribe(newHymn => {
        this.hymns.push(newHymn)
        this.sortHymns()
      })
  }

  delete(id: string) {
    this.hymns = this.hymns.filter(hymn => hymn.id != id)
    this.hymnsService.deleteHymn(id).subscribe()
  }

  sortHymns() {
    this.hymns.sort(((a, b) => a.number - b.number))
  }
}
