import { Component, OnInit, ViewChild } from '@angular/core';
import { PlannerService } from './planner.service';
import { Planner } from './planner.model';
import { faTrashAlt, faEdit } from '@fortawesome/free-solid-svg-icons';
declare var $: any;

@Component({
  selector: 'app-planners',
  templateUrl: './planners.component.html',
  styleUrls: ['./planners.component.css']
})
export class PlannersComponent implements OnInit {
  // @ViewChild('wardName', { static: true }) wardNameInput: any;
  // @ViewChild('presiding', { static: true }) presidingInput: any;
  // @ViewChild('conducting', { static: true }) conductingInput: any;
  // @ViewChild('openingHymn', { static: true }) openingHymnInput: any;
  // @ViewChild('invocation', { static: true }) invocationInput: any;
  // @ViewChild('wardBusiness', { static: true }) wardBusinessInput: any;
  // @ViewChild('sacramentHymn', { static: true }) sacramentHymnInput: any;
  // @ViewChild('sacramentPassing', { static: true }) sacramentPassingInput: any;
  // @ViewChild('Talks', { static: true }) TalksInput: any;
  // @ViewChild('musicalNumber', { static: true }) musicalNumberInput: any;
  // @ViewChild('closingHymn', { static: true }) closingHymnInput: any;
  // @ViewChild('benediction', { static: true }) benedictionInput: any;
  // @ViewChild('dismissalSong', { static: true }) dismissalSongInput: any;
  // @ViewChild('sacramentDate', { static: true }) sacramentDateInput: any;

  faTrashAlt = faTrashAlt
  faEdit = faEdit
  planner: Planner
  public planners: Planner[]
  id: string
  editMode = false

  constructor(private plannerService: PlannerService) { }

  ngOnInit() {
    this.plannerService.getPlanners().subscribe(planners => {
      this.planners = planners
      console.log(JSON.parse(JSON.stringify(this.planners)));
      // console.log(this.planners[1].presiding.firstName);
      this.sortPlanners()
    })
  }

  sortPlanners() {
    this.planners.sort(((a, b) => a.wardName > b.wardName ? 1 : -1))
  }

  create(planner: Planner) {
    this.plannerService.addPlanner(planner)
      .subscribe(newPlanner => {
        this.planners.push(newPlanner)
        this.sortPlanners()
      })

    this.plannerService.getPlanners().subscribe(planners => this.planners = planners)
  }

  edit(planner: Planner) {

  }

  delete(id: string) {
    this.planners = this.planners.filter(planner => planner.id != id)
    this.plannerService.deletePlanner(id).subscribe()
  }

  hideModal() {
    // this.wardNameInput.nativeElement.value = ''
    // this.presidingInput.nativeElement.value = ''
    // this.conductingInput.nativeElement.value = ''
    // this.openingHymnInput.nativeElement.value = ''
    // this.invocationInput.nativeElement.value = ''
    // this.wardBusinessInput.nativeElement.value = ''
    // this.sacramentHymnInput.nativeElement.value = ''
    // this.sacramentPassingInput.nativeElement.value = ''
    // this.TalksInput.nativeElement.value = ''
    // this.musicalNumberInput.nativeElement.value = ''
    // this.closingHymnInput.nativeElement.value = ''
    // this.benedictionInput.nativeElement.value = ''
    // this.dismissalSongInput.nativeElement.value = ''
    // this.sacramentDateInput.nativeElement.value = ''
    $("#member-modal").modal("hide");
  }

  getId(id: string) {
    this.id = id;
    this.plannerService.getPlanner(id).subscribe(planner => this.planner = planner)
  }

  addModeOn() {
    this.editMode = false
    console.log(this.editMode);
  }

  editModeOn() {
    this.editMode = true
    console.log(this.editMode);
  }
}
