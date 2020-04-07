using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
#if !true

            //Iterative 
            int firstnumber = 0, secondnumber = 1, nextnumber, numberOfEmlements;
            Console.WriteLine("Enter the number of Elements to Print");
            numberOfEmlements = int.Parse(Console.ReadLine());
            if (numberOfEmlements < 2)
            {
                Console.WriteLine("Please enter a number greater than 2");
            }
            else
            {
                Console.WriteLine(firstnumber + " " + secondnumber + " ");

                for (int i = 2; i < numberOfEmlements; i++)
                {
                    nextnumber = firstnumber + secondnumber;
                    Console.WriteLine(nextnumber + " ");
                    firstnumber = secondnumber;
                    secondnumber = nextnumber;
                }
            }
            Console.ReadKey();
#elif !true
            Console.WriteLine("Please Enter the Length of Fibonacci Series....");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);

            Console.ReadKey();
#else
            Console.WriteLine("Please enter Nth number of the fibonacci series");
            int Nthnumber = int.Parse(Console.ReadLine());

            Nthnumber = Nthnumber - 1;
            Console.WriteLine(NthFibonacciiNumber(Nthnumber));
            Console.WriteLine(NthFibonacciiNumber1(Nthnumber));
            NthFibonacciiNumber2(Nthnumber);
#endif
        }

        private static void NthFibonacciiNumber2(int nthnumber)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber;

            Console.WriteLine(firstNumber + " " + secondNumber + " ");
            nextNumber = firstNumber + secondNumber;

            for (int i = 2; nextNumber < nthnumber; i++)
            {
                Console.WriteLine(nextNumber + " ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                nextNumber = firstNumber + secondNumber;
            }
        }

        private static int NthFibonacciiNumber1(int nthnumber)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0;
            if (nthnumber == 0)
            {
                return nthnumber;
            }
            for (int i = 2; i <= nthnumber; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return secondNumber;

        }

        private static int NthFibonacciiNumber(int nthnumber)
        {
            if ((nthnumber == 0) || (nthnumber == 1))
            {
                return nthnumber;
            }
            else
            {
                return (NthFibonacciiNumber(nthnumber - 1) + NthFibonacciiNumber(nthnumber - 2));
            }
        }

        private static void FibonacciSeries(int firstnumber, int secondnumber, int counter, int number)
        {
            Console.WriteLine(firstnumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondnumber, firstnumber + secondnumber, counter + 1, number);
            }
        }
    }
}
