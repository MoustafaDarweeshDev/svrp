import { Component , ElementRef, OnInit, ViewChild } from '@angular/core';
import { NgbModal, NgbModalOptions, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements  OnInit{

  @ViewChild('videoModal') videoModal: ElementRef | undefined;
  private videoModalRef: NgbModalRef | undefined;


  constructor(private modalService: NgbModal) {}

  ngOnInit() {
  }


  openVideoModal(){
    const options:NgbModalOptions = {
      animation:true ,
      windowClass: 'video_modal',
      centered: true,
    }

    this.videoModalRef = this.modalService.open(this.videoModal , options)
  }
}
