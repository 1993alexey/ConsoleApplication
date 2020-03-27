import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
<<<<<<< HEAD
import { PlannersComponent } from './planners/planners.component';
import { MembersComponent } from './members/members.component';
=======
>>>>>>> 707ea3e1ddbbe7b3b1e05976c7f6a2225857b4bd
import { HymnsComponent } from './hymns/hymns.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
<<<<<<< HEAD
    CounterComponent,
    FetchDataComponent,
    PlannersComponent,
    MembersComponent,
=======
    FetchDataComponent,
>>>>>>> 707ea3e1ddbbe7b3b1e05976c7f6a2225857b4bd
    HymnsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'hymns', component: HymnsComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
