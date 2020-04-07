using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
#if !true
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;

            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
            Console.ReadKey();
#else
            Console.WriteLine("Enter the start number");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number");
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are :");

            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;

                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadKey();

#endif
        }
    }
}
