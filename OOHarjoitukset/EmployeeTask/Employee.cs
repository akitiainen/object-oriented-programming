using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeTask
{
    class Employee
    {
        public string name;
        public int id;
        public string position;
        public string salary;
        private static int counter = 1;

        public Employee(string name, string position, string salary)
        {
            this.name = name;
            this.id = counter++;
            this.position = position;
            this.salary = salary;
        }

        public string PrintEmployeeInfo()
        {
            return $"Työntekijä:\t {name}\nid:\t\t {id}\nAsema:\t\t {position}\n" +
                $"Palkka:\t\t {salary}";
        }

        public void ComapreSalary(Employee x)
        {

        }
    }
}
