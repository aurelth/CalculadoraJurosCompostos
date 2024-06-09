import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculadoraJcComponent } from './calculadora-jc.component';

describe('CalculadoraJcComponent', () => {
  let component: CalculadoraJcComponent;
  let fixture: ComponentFixture<CalculadoraJcComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CalculadoraJcComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CalculadoraJcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
