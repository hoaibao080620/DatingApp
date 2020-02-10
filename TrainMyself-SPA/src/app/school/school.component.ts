import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from 'protractor';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.css']
})
export class SchoolComponent implements OnInit {
  schools: any;

  constructor(private http: HttpClient) {
    this.http.get('https://localhost:5001/School/Getschools').subscribe(response => {
        this.schools = response;
    }, errors => {
        console.log(errors);
    });
  }

  ngOnInit() {
  }

}
