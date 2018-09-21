import { Injectable } from '@angular/core';

const rootUrl = "http://localhost:5000";

@Injectable({
  providedIn: 'root'
})
export class StaticDataService implements IStaticDataService {

  constructor() { }
}

export interface IStaticDataService {

}