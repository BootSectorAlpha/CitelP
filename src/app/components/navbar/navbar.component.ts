import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  img = 'https://i.ibb.co/jJ3TDhn/logo.png';

  constructor() { }

  ngOnInit(): void {
  }

}
