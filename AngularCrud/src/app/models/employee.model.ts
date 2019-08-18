export class Employee {
    id: number;
    name: string;
    gender: string;
    email?:string;
    phonenumber?:number
    contactPreference:string;
    dateofbirth:Date;
    department: string;
    isActive:boolean;
    photoPath?:string;
}