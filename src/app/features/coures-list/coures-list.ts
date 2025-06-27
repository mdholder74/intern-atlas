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
    this.courseService.getCourses().subscribe({
      next: (courseData: Course[]) => {
        this.courses = courseData;
        console.log('Courses loaded:', this.courses);
      },
      error: (error) => {
        console.error('Error loading courses:', error);
      }
    })
      console.log('CouresList component initialized');
  }

  onCourseBooked(course: Course): void {
    console.log('Course booked:', course);
  
  }

}
