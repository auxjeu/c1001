using System;

namespace c1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
            }

            Console.Write("Here is the array: ");

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            GetMasAndMin(numbers);
            Console.ReadLine();
        }

        static void GetMasAndMin(int[] ary)
        {
            int max = ary[0];
            int min = ary[0];

            foreach (var item in ary)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }

            Console.WriteLine($"max value in array is {max}");
            Console.WriteLine($"min value in array is {min}");
        }
    }
}
