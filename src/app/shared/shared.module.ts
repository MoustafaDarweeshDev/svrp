import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { createPopper } from '@popperjs/core';

import { ContentLayoutComponent } from './components/content-layout/content-layout.component';
import { RouterModule } from '@angular/router';
import { NavbarComponent } from './components/navbar/navbar.component';


@NgModule({
  declarations: [
    ContentLayoutComponent,
    NavbarComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
  ],
  exports:[
    RouterModule,
    ContentLayoutComponent
  ]
})
export class SharedModule { }
