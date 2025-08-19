import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CouresList } from './coures-list';

describe('CouresList', () => {
  let component: CouresList;
  let fixture: ComponentFixture<CouresList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CouresList]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CouresList);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
