using System;
using System.IO;
using System.Linq;

namespace FileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"BST165.txt";
            int size = 165;
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 99);
            }
            File.WriteAllText(Path, string.Join(" ", array));
            Console.WriteLine("Comlete!");
            //string Path = @"Queue100k.txt";
            //int[] array = { 0 };
            //array = File.ReadAllText(Path).Split().Select(int.Parse).ToArray();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    one.add(array[i]);
            //}
        }
    }
}
