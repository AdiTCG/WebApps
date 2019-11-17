import { Component, OnInit } from '@angular/core';
import { NgForm} from '@angular/forms';
import { Department} from '../models/department.model';
import { BsDatepickerConfig } from "ngx-bootstrap/datepicker";

@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})
export class CreateEmployeeComponent implements OnInit {

  datePickerConfig: Partial<BsDatepickerConfig>
  //gender = "female";
  depts: Department[] = [
    {id: 1, name: 'IT'},
    {id: 2, name: 'Help desk'},
    {id: 3, name: 'Security'},
    {id: 4, name: 'CSR'}
  ]

  constructor() { 
    this.datePickerConfig = Object.assign({},
      {
        containerClass: 'theme-dark-blue',
        showWeekNumbers: false,
        minDate: new Date(2019, 8, 3),
        maxDate: new Date(2019, 8, 15)
      });
  }

  ngOnInit() {
  }

  saveEmployee(empForm: NgForm) : void{
    console.log(empForm.value);
  }
}
