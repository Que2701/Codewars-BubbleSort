using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 1, 4, 2, 8 };
            Console.WriteLine("Before swap:");
            foreach (var number in numbers)
            {
                Console.Write($" {number} ");
            }
            Console.WriteLine($"\nAfter swap:");
            BubbleSort(numbers);
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n\n");
            Console.Read();
        }

        static int[] BubbleSort(int[] numbers)
        {
            int swapValue = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        swapValue = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = swapValue;
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine(String.Join(",", numbers));
                    }
                }
            }
            
            return numbers;
        }
    }
}
