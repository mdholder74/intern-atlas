import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SummerSection } from './summer-section';

describe('SummerSection', () => {
  let component: SummerSection;
  let fixture: ComponentFixture<SummerSection>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SummerSection]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SummerSection);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
