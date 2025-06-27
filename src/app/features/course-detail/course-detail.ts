import { Component, OnInit } from '@angular/core';
import { Course } from '../../models/course.model';
import { CourseService } from '../../services/course';

@Component({
  selector: 'app-course-detail',
  standalone: false,
  templateUrl: './course-detail.html',
  styleUrl: './course-detail.css'
})
export class CourseDetail {
    course: Course | null = null;

  constructor (private courseService: CourseService){}

  loadCourseById(id:number): void {
    this.courseService.getCourseById(id).subscribe({
      next: (courseData: Course) => {
        this.course = courseData;
        console.log('Course loaded:', courseData);
      },
      error: (error) => {
        console.error('Error loading course:', error);
      }
    }) 
  }

}
