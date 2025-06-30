import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CourseDetail } from './features/course-detail/course-detail';
import { CouresList } from './features/coures-list/coures-list';

// Define the routes for the application
// Each route maps a path to a component and can include a title for the page
const routes: Routes = [
  { path: '', redirectTo: '/courses', pathMatch: 'full' }, // Redirect empty path to home. For example localhost:4200/ chnages to /home 
  { path: 'courses', component: CouresList, title: 'Course-List' },
  { path: 'courses/:id', component: CourseDetail }, 
  { path: 'commit-forms/:id', component: CourseDetail, title: 'Commit-Course' } // This route is for committing to a course, it uses the same component as course detail
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],// Use forRoot in the main app routing module meaning this is the main routing configuration
  exports: [RouterModule]
})
export class AppRoutingModule { }
