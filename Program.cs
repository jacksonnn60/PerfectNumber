using System;

namespace Udemy__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");

            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            int counter = 0;

            for (int i = 1; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    sum += i;

                    counter++;
                }
            }
            int[] arr = new int[] { sum };

            if (arr[arr.Length - 1] == number)
            {
                
                Console.WriteLine("given number is  a perfect number");
            }
            else
            {
                Console.WriteLine("given number is not a perfect number");
            }
        }
    }
}
