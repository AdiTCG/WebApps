import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Department } from '../models/department.model';

@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})
export class CreateEmployeeComponent implements OnInit {

  constructor() { }
  gender = 'male'
  active = true
  department = 'IT'
  departments: Department[] = [
    { id: 1, name: 'Help Desk' },
    { id: 2, name: 'IT' },
    { id: 3, name: 'Admin' },
    { id: 5, name: 'NewDept' },
    { id: 4, name: 'Payroll' }
  ]

  ngOnInit() {
  }
  saveEmployee(empForm: NgForm): void {
    console.log(empForm.value);
  }

}
