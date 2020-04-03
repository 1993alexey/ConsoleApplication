import { Component, OnInit, ViewChild } from '@angular/core';
import { PlannerService } from './planner.service';
import { Planner } from './planner.model';
import { faTrashAlt, faEdit } from '@fortawesome/free-solid-svg-icons';
import { Member } from '../members/member.model';
import { Hymn } from '../hymns/hymn.model';
import { MemberService } from '../members/member.service';
import { HymnService } from '../hymns/hymn.service';
import { Talk } from '../talk.model';
import { Router } from '@angular/router';
declare var $: any;

@Component({
  selector: 'app-planners',
  templateUrl: './planners.component.html',
  styleUrls: ['./planners.component.css']
})
export class PlannersComponent implements OnInit {
  @ViewChild('wardName', { static: true }) wardNameInput: any;
  @ViewChild('presiding', { static: true }) presidingInput: any;
  @ViewChild('conducting', { static: true }) conductingInput: any;
  @ViewChild('openingHymn', { static: true }) openingHymnInput: any;
  @ViewChild('invocation', { static: true }) invocationInput: any;
  @ViewChild('wardBusiness', { static: true }) wardBusinessInput: any;
  @ViewChild('sacramentHymn', { static: true }) sacramentHymnInput: any;
  @ViewChild('sacramentPassing', { static: true }) sacramentPassingInput: any;
  @ViewChild('speaker', { static: true }) speakerInput: any;
  @ViewChild('musicalNumber', { static: true }) musicalNumberInput: any;
  @ViewChild('closingHymn', { static: true }) closingHymnInput: any;
  @ViewChild('benediction', { static: true }) benedictionInput: any;
  @ViewChild('dismissalSong', { static: true }) dismissalSongInput: any;
  @ViewChild('sacramentDate', { static: true }) sacramentDateInput: any;

  faTrashAlt = faTrashAlt
  faEdit = faEdit
  public planners: Planner[]
  onePlanner = new Planner()
  public members: Member[]
  public hymns: Hymn[]
  editMode = false

  constructor(private plannerService: PlannerService, private memberService: MemberService, private hymnService: HymnService,
    private router: Router) { }

  ngOnInit() {
    this.plannerService.getPlanners().subscribe(planners => {
      this.planners = planners
      this.sortPlanners()

      console.log(JSON.parse(JSON.stringify(this.planners)));
      console.log(this.planners[0].sacramentDate)
    })

    this.memberService.getMembers().subscribe(members => this.members = members)
    this.hymnService.getHymns().subscribe(hymns => this.hymns = hymns)
  }

  sortPlanners() {
    this.planners.sort(((a, b) => a.wardName > b.wardName ? 1 : -1))
  }

  create() {
    this.slepiPirozhok()

    this.plannerService.addPlanner(this.onePlanner)
      .subscribe(newPlanner => {
        this.planners.push(newPlanner)
        this.sortPlanners()
      })

    this.plannerService.getPlanners().subscribe(planners => this.planners = planners)
  }

  edit() {
    this.slepiPirozhok()
    this.plannerService.updatePlanner(this.onePlanner).subscribe()
  }

  delete(id: string) {
    this.planners = this.planners.filter(planner => planner.id != id)
    this.plannerService.deletePlanner(id).subscribe()
  }

  showModal(planner: Planner) {
    if (!planner)
      this.onePlanner = new Planner()
    else
      this.onePlanner = planner

    this.editMode = planner ? true : false
    $("#planner-modal").modal("show");
  }

  hideModal() {
    this.onePlanner = new Planner()
    $("#planner-modal").modal("hide");
  }

  addTalk() {
    this.onePlanner.talks.push(new Talk())
  }

  slepiPirozhok() {
    this.onePlanner.presiding = this.getMember(this.presidingInput.nativeElement.value)
    this.onePlanner.conducting = this.getMember(this.conductingInput.nativeElement.value)
    this.onePlanner.openingHymn = this.getHymn(this.openingHymnInput.nativeElement.value)
    this.onePlanner.invocation = this.getMember(this.invocationInput.nativeElement.value)
    this.onePlanner.closingHymn = this.getHymn(this.closingHymnInput.nativeElement.value)
    this.onePlanner.benediction = this.getMember(this.benedictionInput.nativeElement.value)
    this.onePlanner.dismissalSong = this.getHymn(this.dismissalSongInput.nativeElement.value)

    if (this.onePlanner.sacramentPassing)
      this.onePlanner.sacramentHymn = this.getHymn((<HTMLInputElement>document.getElementById('sacramentHymn')).value)

    const speakers = document.getElementsByClassName('speaker')
    for (let i = 0; i < this.onePlanner.talks.length; i++) {
      const talk = this.onePlanner.talks[i]
      talk.speaker = this.getMember((<HTMLInputElement>speakers[i]).value)
    }
  }

  getMember(id: string): Member {
    return this.members.find(member => member.id == id)
  }

  getHymn(id: string): Hymn {
    return this.hymns.find(hymn => hymn.id == id)
  }

  openPlanner(id: string) {
    this.router.navigate([`planners/${id}`]);
    console.log('Hello')
  }
}
