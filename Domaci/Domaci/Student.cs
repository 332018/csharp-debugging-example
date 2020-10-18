using System;
using System.Collections.Generic;
using System.Text;

namespace Domaci_2


{
    class Student
    {
        public String Name;
        public String IdNumber;
        public Department Department;
    

    public Student(String Name, String IdNumber, Department Department)
    {
        this.Name = Name;
        this.IdNumber = IdNumber;
        this.Department = Department;
    }
}

}
