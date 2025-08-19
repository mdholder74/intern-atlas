import { TestBed } from '@angular/core/testing';

import { AgileEvent } from './agile-event';

describe('AgileEvent', () => {
  let service: AgileEvent;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AgileEvent);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
