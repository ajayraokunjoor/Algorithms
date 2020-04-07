using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
#if !true


            Console.WriteLine("Enter a number to check  palindrome");
            int number = int.Parse(Console.ReadLine());
            int reminder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                reminder = number % 10;

                sum = (sum * 10) + reminder;

                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.ReadKey();
#elif !true
            Console.WriteLine("Enter a string to check palindrome");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0 ; i--)
            {
                reverse += name[i];
            }
            if (name == reverse)
            {
                Console.WriteLine($"{name} is palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not plaindrome");
            }
            Console.ReadKey();
#elif !true
            Console.WriteLine("Enter a string to check palindrome");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            foreach (char c in name)
            {
                reverse = c + reverse;
            }
            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} is palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not palindrome");
            }
            Console.ReadKey();
#else
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);

            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();

#endif
        }
    }
}
