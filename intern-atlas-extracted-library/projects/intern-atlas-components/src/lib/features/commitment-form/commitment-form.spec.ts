import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommitmentForm } from './commitment-form';

describe('CommitmentForm', () => {
  let component: CommitmentForm;
  let fixture: ComponentFixture<CommitmentForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CommitmentForm]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CommitmentForm);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
