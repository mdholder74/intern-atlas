# Intern Atlas Components Library

This Angular library contains extracted components, services, and models from the intern-atlas project, packaged as a reusable library.

## What's Included

### Models
- **Course Model**: Interface for course data
- **User Model**: Interface for user data  
- **Agile Event Model**: Interface for agile event data
- **Azure Stage Model**: Interface for azure stage data

### Services
- **CourseService**: Service for managing course data and API calls
- **AgileEventService**: Service for agile event management
- **AzureStageService**: Service for azure stage management

### Components
- **SiteNavHeader**: Navigation header component
- **CodeSnippet**: Component for displaying code snippets with copy functionality
- **CommitmentForm**: Form component for course commitment
- **CouresList**: Component for displaying course lists
- **CourseCard**: Component for displaying individual course cards  
- **CourseDetail**: Component for displaying detailed course information

## Installation

### Install from built library
```bash
npm install path/to/intern-atlas-components-library.tgz
```

### Install from source
```bash
git clone <repository-url>
cd intern-atlas-extracted-library
npm install
npm run build
```

## Usage

### 1. Import the Module

In your Angular application's `app.module.ts`:

```typescript
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { InternAtlasComponentsModule } from 'intern-atlas-components';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([]),
    FormsModule,
    ReactiveFormsModule,
    InternAtlasComponentsModule  // Add this line
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
```

### 2. Use Components in Templates

```html
<!-- Navigation Header -->
<app-site-nav-header></app-site-nav-header>

<!-- Course List -->
<app-coures-list></app-coures-list>

<!-- Course Card -->
<app-course-card [course]="selectedCourse"></app-course-card>

<!-- Course Detail -->
<app-course-detail></app-course-detail>

<!-- Code Snippet -->
<app-code-snippet [title]="'Example Code'" [code]="codeExample"></app-code-snippet>

<!-- Commitment Form -->
<app-commitment-form></app-commitment-form>
```

### 3. Use Services in Components

```typescript
import { Component, OnInit } from '@angular/core';
import { CourseService, Course } from 'intern-atlas-components';

@Component({
  selector: 'app-my-component',
  template: '<div>My Component</div>'
})
export class MyComponent implements OnInit {
  courses: Course[] = [];

  constructor(private courseService: CourseService) {}

  ngOnInit() {
    this.courseService.getCourses().subscribe(courses => {
      this.courses = courses;
    });
  }
}
```

### 4. Use Models

```typescript
import { Course, User } from 'intern-atlas-components';

export class MyService {
  createUser(): User {
    return {
      id: 1,
      name: 'John Doe',
      email: 'john@example.com',
      committedCourseIds: [1, 2, 3]
    };
  }

  createCourse(): Course {
    return {
      id: 1,
      title: 'Angular Basics',
      description: 'Learn Angular fundamentals',
      estimatedEffort: '10 hours',
      difficulty: 'Beginner'
    };
  }
}
```

## API Configuration

The services expect a backend API running on `http://localhost:3000` by default. You can override this by providing your own service implementations or by modifying the base URL in the services.

### Backend API Endpoints Expected:
- `GET /courses` - Get all courses
- `GET /courses/:id` - Get specific course
- `POST /courses` - Create new course
- `POST /users` - Create new user
- `POST /courses/:courseId/users/:userId` - Add user to course
- `GET /agileEvents` - Get agile events
- `GET /azureStages` - Get azure stages

## Building the Library

```bash
npm run build
```

The built library will be in the `dist/intern-atlas-components` directory.

## Publishing

To publish to npm:

```bash
cd dist/intern-atlas-components
npm publish
```

## Dependencies

This library requires the following peer dependencies in your Angular application:

- `@angular/common: ^20.0.0`
- `@angular/core: ^20.0.0`
- `@angular/forms: ^20.0.0`
- `@angular/router: ^20.0.0`
- `rxjs: ~7.8.0`

## Component Selectors

All components use the `app-` prefix:
- `app-site-nav-header`
- `app-code-snippet`
- `app-commitment-form`
- `app-coures-list`
- `app-course-card`
- `app-course-detail`

## Styling

Components include their own CSS styles. Make sure your application supports component-scoped styles.

## Development

This library was extracted from the intern-atlas project and maintains the original component structure and functionality.

### History Preservation
The extraction process preserved the commit history for all included components and services from the original repository.

## License

[Add your license information here]

## Contributing

[Add contributing guidelines here]
