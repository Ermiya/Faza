import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonnelContractComponent } from './personnel-contract.component';

describe('PersonnelContractComponent', () => {
  let component: PersonnelContractComponent;
  let fixture: ComponentFixture<PersonnelContractComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonnelContractComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonnelContractComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
