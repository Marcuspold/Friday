using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {

            string fridayDirectoryFile = @"C:\Users\opilane\Friday\SampleDirectories.txt";
            string SampleDirectory = @"C:\Users\opilane\Samples";


            string[] includeNestedDirectories = Directory.GetDirectories(SampleDirectory, "*", SearchOption.AllDirectories);
            ReadArray(includeNestedDirectories);

            File.WriteAllLines(fridayDirectoryFile, includeNestedDirectories);

           
        }
        public static void ReadArray(string[] array)
        {
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
