import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Course } from '../../models/course.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-course-card',
  standalone: false,
  templateUrl: './course-card.html',
  styleUrl: './course-card.css',
})
export class CourseCard {
  @Input() course?: Course;
  // @Output() courseBooked = new EventEmitter<any>();

  constructor(private router: Router) {}

  // onCourseBooked() {
  //   this.courseBooked.emit(this.course);
  // }

  onViewDetails(courseId: number): void {
    this.router.navigate(['/courses', courseId]);
  }
  onCommitToCourse(): void {
    if (this.course?.id)
      this.router.navigate(['/commit-forms', this.course.id]);
  }
}
