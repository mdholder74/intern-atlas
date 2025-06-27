import { Injectable } from '@angular/core';
import { Course } from '../models/course.model';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

    private courses: Course[] = [
    {
      id: 1,
      title: "Setting Up Your Angular Development Environment",
      description: "Learn how to install Angular CLI and set up your first project.",
      duration: 1,
      level: "beginner",
      link: "https://angular.io/guide/setup-local",
      img: "favicon.ico"
    },
    {
      id: 2,
      title: "Standalone vs Traditional Components",
      description: "Understand the difference between standalone components and NgModules.",
      duration: 1,
      level: "intermediate",
      link: "https://angular.io/guide/standalone-components",
      img: "favicon.ico"
    },
    {
      id: 3,
      title: "Components: Building blocks of UI",
      description: "Explore how components define the structure and behavior of your app’s UI.",
      duration: 2,
      level: "beginner",
      link: "https://angular.io/guide/component-overview",
      img: "favicon.ico"
    },
    {
      id: 4,
      title: "Services: Logic and data sharing",
      description: "Use services to share logic and data across components.",
      duration: 1.5,
      level: "intermediate",
      link: "https://angular.io/guide/architecture-services",
      img: "favicon.ico"
    },
    {
      id: 5,
      title: "Routing: Navigation between views",
      description: "Set up routes to navigate between different parts of your app.",
      duration: 2,
      level: "intermediate",
      link: "https://angular.io/guide/router",
      img: "favicon.ico"
    },
    {
      id: 6,
      title: "RxJS: Handling async data and operators",
      description: "Use RxJS to manage asynchronous data streams and events.",
      duration: 2,
      level: "advanced",
      link: "https://rxjs.dev/guide/overview",
      img: "https://rxjs.dev/assets/images/logos/Rx_Logo_S.png"
    },
    {
      id: 7,
      title: "Signals",
      description: "Learn about Angular Signals for reactive state management.",
      duration: 1.5,
      level: "intermediate",
      link: "https://angular.io/guide/signals",
      img: "favicon.ico"
    }
  ];

  constructor() { }

    getCourses(): Course[] {
    return this.courses;
  }
}
