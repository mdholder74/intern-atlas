import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InternAtlasComponents } from './intern-atlas-components';

describe('InternAtlasComponents', () => {
  let component: InternAtlasComponents;
  let fixture: ComponentFixture<InternAtlasComponents>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InternAtlasComponents]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InternAtlasComponents);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
