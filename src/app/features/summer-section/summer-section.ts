import { Component, OnInit } from '@angular/core';
import { AgileEvent } from '../../models/agile-event.model';
import { AgileEventService } from '../../services/agile-event';
import { AzureStageService } from '../../services/azure-stage';
import { AzureStage } from '../../models/azure-stage.model';

@Component({
  selector: 'app-summer-section',
  standalone: false,
  templateUrl: './summer-section.html',
  styleUrl: './summer-section.css',
})
export class SummerSection implements OnInit {
  agileEvents: AgileEvent[] = []; // Array to hold Agile events that will be passed to the agile section component
  azureStages: AzureStage[] = []; // Array to hold Azure stages that will be passed to the azure section component

  constructor(
    private agileEvent: AgileEventService,
    private azureStage: AzureStageService
  ) {}

  ngOnInit(): void {
    this.agileEvent.getAgileEvents().subscribe({
      next: (eventsData: AgileEvent[]) => {
        this.agileEvents = eventsData;
      },
      error: (err: any) => console.error('Failed to load Agile events:', err),
    });

    this.azureStage.getAzureStages().subscribe({
      next: (stagesData: AzureStage[]) => {
        this.azureStages = stagesData;
      },
      error: (err: any) => console.error('Failed to load Azure stages:', err),
    });
  }
}
