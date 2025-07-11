import { Component, Input, OnInit } from '@angular/core';
import { AgileEventService } from '../../services/agile-event';
import { AgileEvent } from '../../models/agile-event.model';

@Component({
  selector: 'app-agile-section',
  standalone: false,
  templateUrl: './agile-section.html',
  styleUrl: './agile-section.css'
})
export class AgileSection  {

  @Input() event!: AgileEvent; // Single Agile event that will be passed from the parent component summer-section

}
