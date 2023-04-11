import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { HomeRoutingModule } from './home-routing.module';
import { MainComponent } from './main/main.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { WishListComponent } from './wish-list/wish-list.component';
import { LoginComponent } from './login/login.component';
import { SharedModule } from '../shared/shared.module';
import { HomeComponent } from './home.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {TranslateLoader, TranslateModule} from '@ngx-translate/core';
import {TranslateHttpLoader} from '@ngx-translate/http-loader';
import {HttpClient, HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    MainComponent,
    ContactUsComponent,
    WishListComponent,
    LoginComponent,
    HomeComponent
  ],
  imports: [
    RouterModule,
    CommonModule,
    HomeRoutingModule,
    FormsModule,
    SharedModule,
    NgbModule,
    HttpClientModule,
    TranslateModule
  ]
})
export class HomeModule { }
