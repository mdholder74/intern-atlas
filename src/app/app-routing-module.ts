import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CourseDetail } from './features/course-detail/course-detail';
import { CouresList } from './features/coures-list/coures-list';
import { CommitmentForm } from './features/commitment-form/commitment-form';
import { AboutSection } from './features/about-section/about-section';
import { SummerSection } from './features/summer-section/summer-section';

// Define the routes for the application
// Each route maps a path to a component and can include a title for the page
const routes: Routes = [
  { path: '', redirectTo: '/about', pathMatch: 'full' }, // Redirect empty path to home. For example localhost:4200/ chnages to /home 
  { path: 'about', component: AboutSection, title: 'About' }, // This route is for the about section
  { path: 'courses', component: CouresList, title: 'Course List' },
  { path: 'summer-in-a-bottle', component: SummerSection, title: 'Summer in a Bottle' }, // This route is for the summer section
  { path: 'courses/:id', component: CourseDetail }, 
  { path: 'commit-forms/:id', component: CommitmentForm, title: 'Commit to Course' } // This route is for committing to a course, it uses the same component as course detail
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],// Use forRoot in the main app routing module meaning this is the main routing configuration
  exports: [RouterModule]
})
export class AppRoutingModule { }
