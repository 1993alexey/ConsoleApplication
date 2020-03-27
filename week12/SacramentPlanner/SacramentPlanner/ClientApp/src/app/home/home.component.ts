import { Component, OnInit } from '@angular/core';
import { HymnService } from '../services/hymn.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  constructor(private hymnService: HymnService) { }

  ngOnInit(): void {
    this.hymnService.getHymns().subscribe(console.log)
  }
}
