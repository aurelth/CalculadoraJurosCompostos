import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-calculadora-jc',
  templateUrl: './calculadora-jc.component.html',
  styleUrls: ['./calculadora-jc.component.css'],
})
export class CalculadoraJcComponent implements OnInit {
  numberForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.numberForm = this.fb.group({
      number1: [null, [Validators.required, Validators.min(0)]],
      number2: [null, [Validators.required, Validators.min(0)]],
      number3: [null, [Validators.required, Validators.min(0)]],
    });
  }

  ngOnInit(): void {}

  onSubmit() {
    if (this.numberForm.valid) {
      console.log(this.numberForm.value);
    }
  }
}
