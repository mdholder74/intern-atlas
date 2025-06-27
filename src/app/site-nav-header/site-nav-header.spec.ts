import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SiteNavHeader } from './site-nav-header';

describe('SiteNavHeader', () => {
  let component: SiteNavHeader;
  let fixture: ComponentFixture<SiteNavHeader>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SiteNavHeader]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SiteNavHeader);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
