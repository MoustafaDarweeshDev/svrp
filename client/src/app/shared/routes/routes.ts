import { Routes } from '@angular/router';

export const content: Routes = [
  {
    path: '',
    loadChildren:()=>import('./../../home/home.module').then(m=>m.HomeModule)
  }
];
