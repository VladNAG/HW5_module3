using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_module3
{
    internal class Starer
    {
        public static async void Start()
        {
            var concatenatedText = await ConcatenateFilesAsync(@"C:\Users\vladn\c#\HW5_module3\Hello.txt", @"C:\Users\vladn\c#\HW5_module3\World.txt");

            Console.WriteLine(concatenatedText);
        }

        public static async Task<string> ReadFileAsync(string path)
        {
            using var streamReader = new StreamReader(path);
            return await streamReader.ReadToEndAsync();
        }

        public static async Task<string> ConcatenateFilesAsync(string path1, string path2)
        {
            var task1 = ReadFileAsync(path1);
            var task2 = ReadFileAsync(path2);

            await Task.WhenAll(task1, task2);

            return task1.Result + task2.Result;
        }
    }
}
