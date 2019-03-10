using System;

namespace Tuoterekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filePath = @"C:\dev\TEMP\items.json";
            FileManager file = new FileManager(filePath);
            file.ReadJson();
            do
            {
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(file.PrintJson());
                        Console.WriteLine("Tulosta yhden tuotteen kaikki tiedot? K/E");
                        input = Console.ReadKey();
                        if (input.Key == ConsoleKey.K)
                        {
                            Console.Clear();
                            Console.WriteLine(file.PrintJson());
                            file.FindItem(IdInput());
                        }
                        else
                            Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        file.PrintByGroup(GroupName());
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        file.PrintZeroStock();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("1. Lisää kommentti\n" +
                            "2. Poista kommentti");
                        input = Console.ReadKey();
                        if(input.Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            file.AddComment(IdInput());
                        }
                        else if(input.Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            file.DeleteComment(IdInput());
                        }
                        else
                            Console.WriteLine("Väärä syöte, palataan alkuun.");
                        break;
                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Väärä valinta!");
                        break;
                }
                file.UpdateFile();
                Console.WriteLine("Paina näppäintä jatkaaksesi...");
                Console.ReadKey();
                Console.Clear();
                
            } while (true);
            
        }

        static void Intro()
        {
            Console.WriteLine("1. Tulosta kaikki tuotteet");
            Console.WriteLine("2. Tulosta tuotteet ryhmän mukaan");
            Console.WriteLine("3. Tulosta varastosta puuttuvat tuotteet");
            Console.WriteLine("4. Lisää tai poista tuotteen kommentti");
            Console.WriteLine("X. Poistu ohjelmasta");
        }

        static int IdInput()
        {
            Console.Write("Syötä tuotteen id:");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Syöttämäsi id ei ole numero!");
            }
            return input;

        }

        static ConsoleKeyInfo Group()
        {
            Console.Clear();
            Console.WriteLine("1. Lajittelu ja säilytys\n" +
                "2. Paperit ja lehtiöt\n" +
                "3. Kynät\n" +
                "4. Kortit ja kirjekuoret");
            return Console.ReadKey();
        }

        static string GroupName()
        {
            string s = string.Empty;
            switch (Group().Key)
            {
                case ConsoleKey.D1:
                    s = "Lajittelu ja säilytys";
                    break;
                case ConsoleKey.D2:
                    s = "Paperit ja lehtiöt";
                    break;
                case ConsoleKey.D3:
                    s = "Kynät";
                    break;
                case ConsoleKey.D4:
                    s = "Kortit ja kirjekuoret";
                    break;
                default:
                    break;
            }
            Console.Clear();
            return s;
        }
    }
}
