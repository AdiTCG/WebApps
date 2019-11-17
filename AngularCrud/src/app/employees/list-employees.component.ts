import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee.model';

@Component({
  
  templateUrl: './list-employees.component.html',
  styleUrls: ['./list-employees.component.css']
})
export class ListEmployeesComponent implements OnInit {
  employees: Employee[] =[
    {
      id: 1,
     name: 'Antu',
     gender: 'Male',
     phoneNumber: 1231231,
     contactPreference: 'Phone',
    dateOfBirth: new Date('1990-07-18'),
    department: 'CPM',
    isActive: true,
    photoPath:'/assets/images/IMG_20180428_180310204.jpg'
    },
    {
      id: 2,
     name: 'Bantu',
     gender: 'Male',
     phoneNumber: 2231231,
     contactPreference: 'Phone',
    dateOfBirth: new Date('1990-07-18'),
    department: 'CPM',
    isActive: true,
    photoPath:'/assets/images/IMG_20180428_180310204.jpg'
    },
    {
      id: 3,
     name: 'Shruti',
     gender: 'Female',
     phoneNumber: 1231241,
     contactPreference: 'Phone',
    dateOfBirth: new Date('1993-01-19'),
    department: 'CPM',
    isActive: true,
    photoPath:'/assets/images/IMG_20180430_131158324.jpg'
    }
  ];
  constructor() { }

  ngOnInit() {
  }

}
