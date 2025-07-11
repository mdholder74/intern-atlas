import { Component, OnInit } from '@angular/core';
import { Course } from '../../models/course.model';
import { CourseService } from '../../services/course';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-coures-list',
  standalone: false,
  templateUrl: './coures-list.html',
  styleUrl: './coures-list.css',
})
export class CouresList implements OnInit {
  courses: Course[] = [];

  constructor(
    private courseService: CourseService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.queryParamMap.subscribe((params) => {
      const description = params.get('description');
      this.loadCourses(description);
    });
  }

  loadCourses(description: string | null) {
    this.courseService.getCourses(description).subscribe({
      next: (courseData: Course[]) => {
        this.courses = courseData;
        console.log('Courses loaded:', this.courses);
      },
      error: (error) => {
        console.error('Error loading courses:', error);
      },
    });
  }

  onCourseBooked(course: Course): void {
    console.log('Course booked:', course);
  }
}
