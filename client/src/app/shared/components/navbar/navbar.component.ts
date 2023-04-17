import { Component , OnInit } from '@angular/core';
import { LanguageService } from '../../services/language.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit{

  constructor(private languageService:LanguageService) {}

  ngOnInit(): void {
  }

  rtl(){
    this.languageService.languageConversionToRTL();
  }

  ltr(){
    this.languageService.languageConversionToLTR();
  }

}
