import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main-menu',
  templateUrl: './main-menu.component.html',
  styleUrls: ['./main-menu.component.scss']
})
export class MainMenuComponent implements OnInit {
  menuItems = ["Dashboard", "Monitoring", "Elections", "Persons", "Settings", "Log Out"];
  constructor() { }

  ngOnInit() {
  }

}
