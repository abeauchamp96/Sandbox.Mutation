import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BarService {

  constructor() { }

  public isPersonOldEnough(age: number): boolean {
    return age >= 18;
  }
}
