import { Component, OnInit } from '@angular/core';
import { BirdService } from 'src/app/shared/bird.service';

@Component({
  selector: 'app-image-upload',
  templateUrl: './image-upload.component.html',
  styleUrls: ['./image-upload.component.css']
})
export class ImageUploadComponent implements OnInit {
  selectedFile: File = null;

  constructor(private birdService: BirdService) { }

  ngOnInit(): void {
  }

  onFileSelected(event: any) {

    this.selectedFile = event.target.files[0];

    //Perform validation here
  }

  onUpload() {
    if (this.onFileSelected.length === 0)
      return;
    
    this.birdService.imageUpload(<File>this.selectedFile);
  }
}
