import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DescriptionRulingsComponent } from './description-rulings.component';

describe('DescriptionRulingsComponent', () => {
  let component: DescriptionRulingsComponent;
  let fixture: ComponentFixture<DescriptionRulingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DescriptionRulingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DescriptionRulingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
