using System;
using System.IO;

namespace test_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDirectory = "Samples";

            CreateMyDirectory(newDirectory);
        }
        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string directoryFullPath = $@"{rootDirectory}\{myDirectoryName}";
            if (Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {rootDirectory}.");
            }
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\Samples";
            string fileName = "stars.txt; planets.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);

            return dataFromFile;
        }
        private static string GetLinesFromfileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";

            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }

        

    }
}
