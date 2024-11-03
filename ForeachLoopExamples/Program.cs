using System;
using System.Collections.Generic;

namespace ForeachLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir dizi tanımlama ve elemanlarını yazdırma
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array elements:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Bir liste tanımlama ve elemanlarını yazdırma
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            Console.WriteLine("\nNames list elements:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Dizideki çift sayıları bulma
            Console.WriteLine("\nEven numbers in the array:");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();

            // Liste elemanlarını büyük harfe çevirerek yazdırma
            Console.WriteLine("\nNames in uppercase:");
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }
        }
    }
}