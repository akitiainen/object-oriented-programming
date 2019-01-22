using System;

namespace EmployeeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("make", "työm mies", 2500.00);
            employees[1] = new Employee("pete", "johtJA", 100500);
            employees[2] = new Employee("patrik", "apu poika", 3.50);
            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.PrintEmployeeInfo()}\n" +
                    $"_________________________________\n");
            }

            if(AskUser() == true)
                employees[SalaryMan()].ComapreSalary(employees[SalaryMan()]);
        }

        static bool AskUser()
        {
            Console.WriteLine("Haluatko vertailla palkkoja?\n" +
                "1: kyllä\n2: en");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1)
                return true;
            else if (input.Key == ConsoleKey.D2)
                return false;
            else
                return false;
        }

        static int SalaryMan()
        {
            Console.Clear();
            do
            {
            Console.WriteLine("Kenen palkkoja haluat vertailla:");
            Console.WriteLine("1. make\n2. pete\n3. patrik");
            var input = Console.ReadKey();
                if (input.Key == ConsoleKey.D1)
                    return 0;
                else if (input.Key == ConsoleKey.D2)
                    return 1;
                else if (input.Key == ConsoleKey.D3)
                    return 2;
                else
                    Console.Clear();
                    Console.WriteLine($"henkilöä ei ole olemassa!");
            } while (true);
        }
    }
}
