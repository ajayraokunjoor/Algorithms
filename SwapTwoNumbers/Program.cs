using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 20, temp;
            Console.WriteLine($"Before Swapping - number1 = {number1}, number2 = {number2}");
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"After Swapping - number1 = {number1}, number2 = {number2}");
            Console.ReadKey();

            Console.WriteLine($"Before Swapping - number1 = {number1}, number2 = {number2}");
            number1 = number1 * number2; //number1=200 (10*20) 
            number2 = number1 / number2; //number2=10 (200/20)
            number1 = number1 / number2; //number1=20 (200/10) 
            Console.WriteLine($"After Swapping - number1 = {number1}, number2 = {number2}");
            Console.ReadKey();
            
            Console.WriteLine($"Before Swapping - number1 = {number1}, number2 = {number2}");
            number1 = number1 + number2; //number1=30 (10+20) 
            number2 = number1 - number2; //number2=10 (30-20)
            number1 = number1 - number2; //number1=20 (30-10) 
            Console.WriteLine($"After Swapping - number1 = {number1}, number2 = {number2}");
            Console.ReadKey();

            string name1 = "DotNet", name2 = "Tutorials";
            Console.WriteLine($"Before Swapping name1 = {name1}, name2 = {name2}");
            name1 = name1 + name2;
            name2 = name1.Substring(0, name1.Length - name2.Length);
            name1 = name1.Substring(name2.Length);
            Console.WriteLine($"After Swapping name1 = {name1}, name2 = {name2}");
            Console.ReadKey();
        }
    }
}
