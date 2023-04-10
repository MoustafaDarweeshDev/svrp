import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentLayoutComponent } from './shared/components/content-layout/content-layout.component';
import { content } from './shared/routes/routes';

const routes: Routes = [
  {
    path:'',
    component:ContentLayoutComponent,
    children:content
  },
  {
    path:'',
    loadChildren:()=>import('./shared/shared.module').then(mod=>mod.SharedModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
