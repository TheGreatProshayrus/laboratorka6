using System;
using System.Collections.Generic;
using System.IO;

namespace laba6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = ScanMediaFolder(System.AppContext.BaseDirectory);           

            Console.WriteLine("Найденные файлы:");

            foreach (var item in items)
                item.PrintAllManipulationOptions();

            Console.WriteLine();

            Console.ReadLine();
        }

        static List<PlayerItem> ScanMediaFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                throw new Exception("Папка не существует");

            var result = new List<PlayerItem>();
            var files = Directory.EnumerateFiles(folderPath);

            foreach (var file in files)
            {
                string extension = Path.GetExtension(file);

                switch (extension)
                {
                    case ".mkv":
                        result.Add(new PlayerItem(new MkvFile(file)));
                        break;
                    case ".mp3":
                        result.Add(new PlayerItem(new Mp3File(file)));
                        break;
                    case ".wav":
                        result.Add(new PlayerItem(new WavFile(file)));
                        break;
                }
            }

            return result;
        }
    }
}
