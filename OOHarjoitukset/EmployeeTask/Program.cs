using System;

namespace EmployeeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("make",  "työm mies", "kalja kontti");
            employees[1] = new Employee("pete",  "johtJA", "maken vaimo");
            employees[2] = new Employee("pate",  "alinta paskaa", "5snt");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.PrintEmployeeInfo()}\n" +
                    $"_________________________________\n");
            }
            
        }
    }
}
