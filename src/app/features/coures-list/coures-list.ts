import { Component, OnInit } from '@angular/core';
import { Course } from '../../models/course.model';
import { CourseService } from '../../services/course';

@Component({
  selector: 'app-coures-list',
  standalone: false,
  templateUrl: './coures-list.html',
  styleUrl: './coures-list.css'
})
export class CouresList implements OnInit {
  courses: Course[] = [];

  constructor(private courseService: CourseService) { }

  ngOnInit(): void {
    this.courses = this.courseService.getCourses();
      console.log('CouresList component initialized');
  }

  onCourseBooked(course: Course): void {
    console.log('Course booked:', course);
  
  }

}
