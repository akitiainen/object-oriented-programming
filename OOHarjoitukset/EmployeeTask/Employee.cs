using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeTask
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public double salary;
        private static int counter = 1;

        public Employee(string name, string position, double salary)
        {
            this.name = name;
            this.id = "100" + (counter++).ToString();
            this.position = position;
            this.salary = salary;
        }

        public string PrintEmployeeInfo()
        {
            return $"Työntekijä:\t {name}\nid:\t\t {id}\nAsema:\t\t {position}\n" +
                $"Palkka:\t\t {salary.ToString("c", CultureInfo.CurrentCulture)}";
        }

        public void ComapreSalary(Employee x)
        {
            Console.Clear();
            if(this.salary > x.salary)
                Console.WriteLine($"Henkilön {this.name} palkka {this.salary.ToString("c", CultureInfo.CurrentCulture)}, on suurempi kuin henkilön {x.name} palkka {x.salary.ToString("c", CultureInfo.CurrentCulture)}");
            else
                Console.WriteLine($"Henkilön {x.name} palkka {x.salary.ToString("c", CultureInfo.CurrentCulture)}, on suurempi kuin henkilön {this.name} palkka {this.salary.ToString("c", CultureInfo.CurrentCulture)}");
        }
    }
}
