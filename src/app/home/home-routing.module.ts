import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home.component';
import { MainComponent } from './main/main.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { LoginComponent } from './login/login.component';
import { WishListComponent } from './wish-list/wish-list.component';

const routes: Routes = [
  {
    path:'',
    component:HomeComponent,
    children:[
      {path:'' , pathMatch:'full',component:MainComponent},
      {path:'contact-us' , component:ContactUsComponent},
      {path:'login' , component:LoginComponent},
      {path:'wishlist' , component:WishListComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
