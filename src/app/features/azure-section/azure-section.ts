import { Component, OnInit } from '@angular/core';
import { AzureStageService } from '../../services/azure-stage';
import { AzureStage } from '../../models/azure-stage.model';

@Component({
  selector: 'app-azure-section',
  standalone: false,
  templateUrl: './azure-section.html',
  styleUrl: './azure-section.css',
})
export class AzureSection implements OnInit {
  private azureStages: AzureStage[] = [];

  constructor(private azureStage: AzureStageService) {}

  ngOnInit(): void {
    this.azureStage.getAzureStages().subscribe({
      next: (stagesData: AzureStage[]) => {
        this.azureStages = stagesData;
      },
    });
  }
}
