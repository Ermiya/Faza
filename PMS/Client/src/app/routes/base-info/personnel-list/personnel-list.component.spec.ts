import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonnelListComponent } from './personnel-list.component';

describe('PerosnnelListComponent', () => {
  let component: PersonnelListComponent;
  let fixture: ComponentFixture<PersonnelListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonnelListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonnelListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
