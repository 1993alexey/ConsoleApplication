import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { PlannersComponent } from './planners/planners.component';
import { MembersComponent } from './members/members.component';
import { HymnsComponent } from './hymns/hymns.component';
import { PlannerComponent } from './planners/planner/planner.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    PlannersComponent,
    MembersComponent,
    HymnsComponent,
    PlannerComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    FontAwesomeModule,
    RouterModule.forRoot([
      { path: '', component: PlannersComponent, pathMatch: 'full' },
      { path: 'hymns', component: HymnsComponent },
      { path: 'members', component: MembersComponent },
      { path: 'planners', component: PlannersComponent },
      { path: 'planners/:id', component: PlannerComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
