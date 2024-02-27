﻿namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Двомірний масив:");
            int[,] arr = new int[5, 5];

            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Мінімальне значення масиву:");
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            Console.WriteLine(min);

            Console.WriteLine("Максимальне значення масиву:");
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            Console.WriteLine(max);
            

        }
    }
}
