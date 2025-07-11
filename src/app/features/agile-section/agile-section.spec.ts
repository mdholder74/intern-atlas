import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgileSection } from './agile-section';

describe('AgileSection', () => {
  let component: AgileSection;
  let fixture: ComponentFixture<AgileSection>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AgileSection]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgileSection);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
