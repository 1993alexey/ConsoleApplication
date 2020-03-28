import { Component, OnInit, ViewChild } from '@angular/core';
import { MemberService } from './member.service';
import { Member } from './member.model';
import { faTrashAlt, faEdit } from '@fortawesome/free-solid-svg-icons';
declare var $: any;

@Component({
  selector: 'app-members',
  templateUrl: './members.component.html',
  styleUrls: ['./members.component.css']
})
export class MembersComponent implements OnInit {
  @ViewChild('firstName', { static: true }) memberFirstNameInput: any;
  @ViewChild('lastName', { static: true }) memberlastNameInput: any;
  @ViewChild('memberTitle', { static: true }) memberTitleInput: any;

  faTrashAlt = faTrashAlt
  faEdit = faEdit
  member: Member
  public members: Member[]
  id: string
  lName: string
  fName: string
  mTitle: string
  membersObj: string[]

  constructor(private memberService: MemberService) { }

  ngOnInit() {
    this.memberService.getMembers().subscribe(members => {
      this.members = members
      this.sortMembers()
    })
  }

  sortMembers() {
    this.members.sort(((a, b) => a.lastName > b.lastName ? 1 : -1))
  }

  create(member: Member) {
    this.memberService.getMembers().subscribe(members => this.members = members)

    // this.membersObj = Object.entries(this.members);

    // console.log(this.members);
    // console.log(Object.entries(this.members));

    // this.fName = document.getElementById("fName").value
    // this.lName = document.getElementById("lName").value
    // this.mTitle = document.getElementById("mTitle").value

    // console.log(this.fName + ' ' + this.lName + ' ' + this.mTitle)

    // arr.filter(obj => Object.keys(obj).some(key => obj[key].includes(searchKey)))

    // if (Object.entries(this.members).filter(obj => Object.keys(obj).some(key => obj[key].includes("5")))) {
    //   console.log("found it")
    // } else {
    //   console.log("screw you!")
    // }

    // if (Object.entries(this.members).indexOf(this.fName) > -1) {
    //   console.log("found it")
    // } else {
    //   console.log("screw you!")
    // }

    this.memberService.addMember(member)
      .subscribe(newMember => {
        this.members.push(newMember)
        this.sortMembers()
      })

    this.memberService.getMembers().subscribe(members => this.members = members)
  }


  delete(id: string) {
    this.members = this.members.filter(member => member.id != id)
    this.memberService.deleteMember(id).subscribe()
  }

  hideModal() {
    this.memberFirstNameInput.nativeElement.value = ''
    this.memberlastNameInput.nativeElement.value = ''
    this.memberTitleInput.nativeElement.value = ''
    $("#member-modal").modal("hide");
  }

  getId(id: string) {
    this.id = id;
    this.memberService.getMember(id).subscribe(member => this.member = member)
  }

}
