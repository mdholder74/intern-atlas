import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Course } from '../../models/course.model';

@Component({
  selector: 'app-course-card',
  standalone: false,
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCard {
  @Input() course?: Course[];
  @Output() courseBooked = new EventEmitter<any>();

  onCourseBooked() {
    this.courseBooked.emit(this.course);
  }

}
