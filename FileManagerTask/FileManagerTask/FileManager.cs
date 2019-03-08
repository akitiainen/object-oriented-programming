using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace FileManagerTask
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string _filePath;
        private List<Food> _foodsList;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        public string ReadWords()
        {
            try
            {
                string content = ReadFile();
                return content;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }

        private string ReadFile()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(_filePath);
            string fileName = Path.GetFileName(_filePath);
            string fileExtension = Path.GetExtension(_filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(_filePath, Encoding.UTF8);
            return fileContent;
        }

        public void SetJson()
        {
            List<Food> foods = new List<Food>()
            {
                new Food {Name = "kalja", Price = 12},
                new Food {Name = "makkara", Price = 7},
                new Food {Name = "muna", Price = 9}
            };

            File.WriteAllText(@"C:\dev\TEMP\test.json", JsonConvert.SerializeObject(foods));
        }

        public void GetJson()
        {
            StreamReader reader = new StreamReader(_filePath);
            string json = reader.ReadToEnd();
            _foodsList = JsonConvert.DeserializeObject<List<Food>>(json);
            foreach (var item in _foodsList)
            {
                Console.WriteLine($"Food: {item.Name}\tPrice: {item.Price.ToString("c", CultureInfo.CurrentCulture)}");
            }
        }
    }
}
