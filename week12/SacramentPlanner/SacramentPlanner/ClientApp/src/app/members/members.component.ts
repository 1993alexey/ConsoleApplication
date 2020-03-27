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
  public members: Member[]

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
    // console.log("the new member is " + JSON.stringify(member))
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

}
