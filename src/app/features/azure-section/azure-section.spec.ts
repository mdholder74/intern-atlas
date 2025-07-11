import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AzureSection } from './azure-section';

describe('AzureSection', () => {
  let component: AzureSection;
  let fixture: ComponentFixture<AzureSection>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AzureSection]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AzureSection);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
