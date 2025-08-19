import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { AzureStage } from '../models/azure-stage.model';

@Injectable({
  providedIn: 'root'
})
export class AzureStageService {

  constructor(private http: HttpClient) { }

  private baseUrl = 'http://localhost:3000';

  getAzureStages(): Observable<AzureStage[]> {
    return this.http.get<AzureStage[]>(`${this.baseUrl}/azureStages`);
  }
}
