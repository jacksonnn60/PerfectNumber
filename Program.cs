using System;

namespace Udemy__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            
            //taking a needed number
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            
            for (int i = 1; i <= number - 1; i++)   
            {
                //counting a sums
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            
            //checking for perfect!
            int[] arr = new int[] { sum };

            //if perfect:
            if (arr[arr.Length - 1] == number)
            {
                Console.WriteLine("given number is  a perfect number");
            }
            //if not perfect:
            else
            {
                Console.WriteLine("given number is not a perfect number");
            }
        }
    }
}
