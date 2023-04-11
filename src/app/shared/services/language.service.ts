import { Injectable } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LanguageService {
  public translations: any;

  //change items language
  // private languageSubject: BehaviorSubject<string | null> = new BehaviorSubject(this.localStorageHandler.getItem('selectedLanguageId')); // default language
  // public language$: Observable<string | null> = this.languageSubject.asObservable();
  // public changeLanguageId(language: string): void {
  //   this.languageSubject.next(language);
  // }

  mainBody = document.querySelector('body');
  html = document.querySelector('html');

  constructor(private _translate: TranslateService) {
    _translate.setDefaultLang('en');
    _translate.use('en').subscribe((translations) => {
      this.translations = translations;
    });
  }

  translate(key: string) {
    this._translate.use(key.toString()).subscribe((translations) => {
      this.translations = translations;
    });
  }

  languageConversionToLTR() {
    let styleId = document.querySelector('#style');
    this.mainBody?.classList.add('ltr');
    this.html?.setAttribute('dir', 'ltr');
    styleId?.setAttribute('href', './assets/bootstrap/bootstrap.css');
    this.mainBody?.classList.remove('rtl');
    // this.mainBody?.classList.remove('arabicFont');
    // this.languageService.translate('en');
    this._translate.use('en').subscribe((res) => { });
    this.setLanguage('en');
    // this.SwitcherService.changeLanguage('ltr');
  }

  languageConversionToRTL() {
    let styleId = document.querySelector('#style');
    this.mainBody?.classList.add('rtl');
    this.html?.setAttribute('dir', 'rtl');
    styleId?.setAttribute('href', './assets/bootstrap/bootstrap.rtl.css');
    this.mainBody?.classList.remove('ltr');
    // this.mainBody?.classList.add('arabicFont');
    // this.languageService.translate('ar');
    this._translate.use('ar').subscribe((res) => { });
    this.setLanguage('ar');
    // this.SwitcherService.changeLanguage('rtl');
  }
  private setLanguage(langKey: string) { localStorage.setItem('language', langKey); }

}
