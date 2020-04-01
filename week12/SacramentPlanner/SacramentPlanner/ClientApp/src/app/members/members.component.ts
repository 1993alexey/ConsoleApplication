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
  oneMember = new Member()
  editMode = false

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

    this.memberService.addMember(member)
      .subscribe(newMember => {
        this.members.push(newMember)
        this.sortMembers()
      })

    this.memberService.getMembers().subscribe(members => this.members = members)
  }

  edit() {
    this.memberService.updateMember(this.oneMember).subscribe()
  }

  delete(id: string) {
    this.members = this.members.filter(member => member.id != id)
    this.memberService.deleteMember(id).subscribe()
  }

  showModal(member: Member) {
    if (!member)
      this.oneMember = new Member()
    else
      this.oneMember = member

    this.editMode = member ? true : false
    $("#member-modal").modal("show");
  }

  hideModal() {
    this.oneMember = new Member()
    this.memberFirstNameInput.nativeElement.value = ''
    this.memberlastNameInput.nativeElement.value = ''
    this.memberTitleInput.nativeElement.value = ''
    $("#member-modal").modal("hide");
  }

}
