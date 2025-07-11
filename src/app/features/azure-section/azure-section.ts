import { Component, Input, OnInit } from '@angular/core';
import { AzureStageService } from '../../services/azure-stage';
import { AzureStage } from '../../models/azure-stage.model';

@Component({
  selector: 'app-azure-section',
  standalone: false,
  templateUrl: './azure-section.html',
  styleUrl: './azure-section.css',
})
export class AzureSection{

  @Input() stage!: AzureStage; // Single Azure stage that will be passed from the parent component summer-section

 
}
