import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Bird } from './bird.model';

@Injectable({
  providedIn: 'root'
})
export class BirdService {
  public birds: Bird[];
  public bird: Bird;

  public url: string = "https://localhost:44314/api/birds";

  constructor(private http: HttpClient) {
  }

  //Store the master list of all birds in the catalog
  getBirds() {
    return this.http.get<Bird[]>(this.url)
      .subscribe(
        result => {
          //Sort the bird list by common name, then store them in the service
          this.birds = result.sort((a, b) => (a.commonName > b.commonName) ? 1 : ((b.commonName > a.commonName) ? -1 : 0));
        }
      );
  }

  //Get information on a single bird
  getBird(id: number) {
    return this.http.get<Bird>(`${this.url}/${id}`)
      .subscribe(
        result => {
          this.bird = result;
        }, err => console.error(err));
  }

  //Send an image to the ML model for identification
  identifyBird(selectedFile: any) {

  }



}
