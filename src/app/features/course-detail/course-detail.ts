import { Component, Input, OnInit } from '@angular/core';
import { Course } from '../../models/course.model';
import { CourseService } from '../../services/course';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-course-detail',
  standalone: false,
  templateUrl: './course-detail.html',
  styleUrls: ['./course-detail.css'],
})
export class CourseDetail implements OnInit {
  course: Course | null = null;
  @Input() swaggerUrl?: string;

  constructor(
    private courseService: CourseService,
    private route: ActivatedRoute
  ) {}

  // loadCourseById by default
  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      const courseStringId = params.get('id');
      console.log('Course ID from route:', courseStringId); // Debug log
      if (courseStringId) {
        const id = +courseStringId; // Convert string to number
        this.loadCourseById(id);
      }
    });
  }

  loadCourseById(id: number): void {
    this.courseService.getCourseById(id).subscribe({
      next: (courseData: Course) => {
        this.course = courseData;
        console.log('Course loaded:', courseData);
      },
      error: (error) => {
        console.error('Error loading course:', error);
      },
    });
  }
}
