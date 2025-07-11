import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { AgileEvent } from '../models/agile-event.model';

@Injectable({
  providedIn: 'root'
})
export class AgileEventService {

  constructor(private http: HttpClient) {}

   private baseUrl = 'http://localhost:3000';

  getAgileEvents(): Observable<AgileEvent[]> {
    return this.http.get<AgileEvent[]>(`${this.baseUrl}/agileEvents`);
  }
}
