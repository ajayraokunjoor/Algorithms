using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
#if ReverseNumber
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is : {reverse}");
            Console.ReadKey();
#elif ReverseString
            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            Console.WriteLine($"The Reverse string is : {reverse}");
            Console.ReadKey();
#elif !Reverse_ForEach
            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            Console.Write("Enter a String : ");
            string name1 = Console.ReadLine();
            string reverse = string.Empty;
            foreach (char c in name)
            {
                reverse = c + reverse;
            }
            
            Console.WriteLine($"The Reverse string is : {reverse}");
            Console.ReadKey();
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", number * 2);
            Console.WriteLine("Enter the String");
            string word = Console.ReadLine();
            Console.WriteLine(word);
#elif !Reverse_Array
            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);

            Console.WriteLine($"The Reverse string is : {reverse}");
            Console.ReadKey();
#endif

        }
    }
}
