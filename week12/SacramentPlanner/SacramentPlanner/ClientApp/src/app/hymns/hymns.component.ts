import { Component, OnInit } from '@angular/core';
<<<<<<< HEAD
=======
import { HymnService } from '../services/hymn.service';
import { Hymn } from '../models/hymn.model';
>>>>>>> 707ea3e1ddbbe7b3b1e05976c7f6a2225857b4bd

@Component({
  selector: 'app-hymns',
  templateUrl: './hymns.component.html',
  styleUrls: ['./hymns.component.css']
})
export class HymnsComponent implements OnInit {

<<<<<<< HEAD
  constructor() { }

  ngOnInit() {
=======
  public hymns: Hymn[]
  constructor(private hymnsService: HymnService) { }

  ngOnInit() {
    this.hymnsService.getHymns().subscribe(hymns => this.hymns = hymns)
>>>>>>> 707ea3e1ddbbe7b3b1e05976c7f6a2225857b4bd
  }

}
