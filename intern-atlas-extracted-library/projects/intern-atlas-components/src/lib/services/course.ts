import { Injectable } from '@angular/core';
import { Course } from '../models/course.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user.model';

@Injectable({
  providedIn: 'root',
})
export class CourseService {
  constructor(private http: HttpClient) {}

  private baseUrl = 'http://localhost:3000';

  getCourses(description?: string | null): Observable<Course[]> {
    let url = `${this.baseUrl}/courses`;
    if (description) {
      url += `?description=${description}`;
    }
    return this.http.get<Course[]>(url);
  }

  getCourseById(id: number): Observable<Course> {
    return this.http.get<Course>(`${this.baseUrl}/courses/${id}`);
  }

  addCourse(course: Course): Observable<Course> {
    return this.http.post<Course>(`${this.baseUrl}/courses`, course);
  }

  addUser(user: User): Observable<Course> {
    return this.http.post<Course>(`${this.baseUrl}/users`, user);
  }

  addUserToCourse(userId: number, courseId: number): Observable<Course> {
    return this.http.post<Course>(
      `${this.baseUrl}/courses/${courseId}/users/${userId}`,
      {}
    );
  }
}
