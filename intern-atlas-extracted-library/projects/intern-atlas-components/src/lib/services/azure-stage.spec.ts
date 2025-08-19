import { TestBed } from '@angular/core/testing';

import { AzureStage } from './azure-stage';

describe('AzureStage', () => {
  let service: AzureStage;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AzureStage);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
