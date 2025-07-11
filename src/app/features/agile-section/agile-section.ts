import { Component, OnInit } from '@angular/core';
import { AgileEventService } from '../../services/agile-event';
import { AgileEvent } from '../../models/agile-event.model';

@Component({
  selector: 'app-agile-section',
  standalone: false,
  templateUrl: './agile-section.html',
  styleUrl: './agile-section.css'
})
export class AgileSection implements OnInit {
  agileEvents: AgileEvent[] = [];

  constructor(private agileEvent: AgileEventService) {}

  ngOnInit(): void {
      this.agileEvent.getAgileEvents().subscribe({
      next: (eventsData: AgileEvent[]) => {
          this.agileEvents = eventsData;
      }
  });

}

}
