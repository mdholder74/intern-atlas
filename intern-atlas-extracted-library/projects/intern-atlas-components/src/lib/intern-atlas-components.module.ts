import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

// Components
import { SiteNavHeader } from './components/site-nav-header';

// Feature Components
import { CodeSnippet } from './features/code-snippet/code-snippet';
import { CommitmentForm } from './features/commitment-form/commitment-form';
import { CouresList } from './features/coures-list/coures-list';
import { CourseCard } from './features/course-card/course-card';
import { CourseDetail } from './features/course-detail/course-detail';

@NgModule({
  declarations: [
    SiteNavHeader,
    CodeSnippet,
    CommitmentForm,
    CouresList,
    CourseCard,
    CourseDetail
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule
  ],
  exports: [
    SiteNavHeader,
    CodeSnippet,
    CommitmentForm,
    CouresList,
    CourseCard,
    CourseDetail
  ]
})
export class InternAtlasComponentsModule { }