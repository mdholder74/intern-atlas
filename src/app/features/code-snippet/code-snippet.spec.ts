import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeSnippet } from './code-snippet';

describe('CodeSnippet', () => {
  let component: CodeSnippet;
  let fixture: ComponentFixture<CodeSnippet>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CodeSnippet]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CodeSnippet);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
