import { Component, OnInit } from '@angular/core';
import { HymnService } from '../services/hymn.service';
import { Hymn } from '../models/hymn.model';

@Component({
  selector: 'app-hymns',
  templateUrl: './hymns.component.html',
  styleUrls: ['./hymns.component.css']
})
export class HymnsComponent implements OnInit {

  public hymns: Hymn[]
  constructor(private hymnsService: HymnService) { }

  ngOnInit() {
    this.hymnsService.getHymns().subscribe(hymns => this.hymns = hymns)
  }

}
