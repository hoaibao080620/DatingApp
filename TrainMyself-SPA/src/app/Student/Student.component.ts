import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-Student',
  templateUrl: './Student.component.html',
  styleUrls: ['./Student.component.css']
})
export class StudentComponent implements OnInit {
  students: any;
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getStudents();
  }

  getStudents() {
    this.http.get('https://localhost:5001/Student/getStudents').subscribe(x => {
      this.students = x;
    }, error => {
      console.log(error);
    });
  }
}
