import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { CouresList } from './features/coures-list/coures-list';
import { CourseCard } from './features/course-card/course-card';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { CourseDetail } from './features/course-detail/course-detail';
import { SiteNavHeader } from './site-nav-header/site-nav-header';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    App,
    CouresList,
    CourseCard,
    CourseDetail,
    SiteNavHeader
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideHttpClient(),
  ],
  bootstrap: [App]
})
export class AppModule { }
