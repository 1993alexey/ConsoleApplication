import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { PlannerService } from '../planner.service';
import { Subscription } from 'rxjs';
import { Planner } from '../planner.model';

@Component({
  selector: 'app-planner',
  templateUrl: './planner.component.html',
  styleUrls: ['./planner.component.css']
})
export class PlannerComponent implements OnInit {

  subscription: Subscription;
  id: string;
  planner: Planner
  originalPlanner: Planner

  constructor(private plannerService: PlannerService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.params.subscribe(
      (params: Params) => {
        this.id = params['id'];
        console.log("the id is " + this.id)
        if (params.id === null || params.id === undefined) {
          // this.editMode = false;
          return;
        }
        this.plannerService.getPlanner(this.id)
          .subscribe(plannerData => {
            this.planner = plannerData
            console.log("here is the planner: " + this.planner.wardName)
          });
      }
    );
  }
}
