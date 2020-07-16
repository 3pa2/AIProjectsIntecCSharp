using System;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
             
                Console.WriteLine("Check is the number you insert is a prime number.");
                Console.WriteLine("Or Press 0 to finish");

                int number = Convert.ToInt32(Console.ReadLine());

                if(number == 0)
                {
                    break;
                }

                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.WriteLine($"the number is prime: {number}");

                }
                else
                {
                    Console.WriteLine($"the number not is prime: {number}");
                }
            }
         

        }
    }
}
