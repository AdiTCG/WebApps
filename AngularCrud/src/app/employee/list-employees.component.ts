import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee.model';

@Component({
  templateUrl: './list-employees.component.html',
  styleUrls: ['./list-employees.component.css']
})
export class ListEmployeesComponent implements OnInit {

  employees: Employee[] = [
    {
      id: 1,
      name: 'Mr. A',
      gender: 'Male',
      phonenumber: 1231231,
      contactPreference: 'Phone',
      dateofbirth: new Date('1990-1-1'),
      department: 'CPM',
      isActive: true,
      photoPath:'assets/images/PAN.jpg'
      },
      {
      id: 2,
      name: 'Mr. S',
      gender: 'Male',
      phonenumber: 2231231,
      contactPreference: 'Phone',
      dateofbirth: new Date('1990-4-4'),
      department: 'CPM',
      isActive: true,
      photoPath:'assets/images/dp.jpeg'
      },
      {
      id: 3,
      name: 'Shruti',
      gender: 'Female',
      phonenumber: 1231241,
      contactPreference: 'Phone',
      dateofbirth: new Date('1993-2-2'),
      department: 'CPM',
      isActive: true,
      photoPath:'assets/images/PAN.jpg'
      }
  ];

  constructor() { }

  ngOnInit() {
  }

}
