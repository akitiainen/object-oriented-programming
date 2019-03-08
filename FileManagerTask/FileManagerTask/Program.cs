using System;

namespace FileManagerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileManager fileManager = new FileManager(@"C:\dev\TEMP\test.txt");
            Console.WriteLine(fileManager.ReadWords());
            Console.WriteLine("________________________\n");

            FileManager fileManagerJson = new FileManager(@"C:\dev\TEMP\test.json");
            fileManagerJson.SetJson();
            fileManagerJson.GetJson();
        }
    }
}
