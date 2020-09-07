using System;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Factorial to an input with conversion of string into integer.
            int res;
            string number;

            Console.WriteLine("Input a number to see the factorial of that number.");
            number = Console.ReadLine();
            res = Convert.ToInt32(number);

            Console.WriteLine("The factorial of your input is " + res * res);
            Console.ReadLine();*/
            int number;
            int number2;
            int sign;


            Console.WriteLine("Input your first number.");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your math sign. 1: Addition, 2: Subtraction, 3: Multiplication, 4: Division");
            sign = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number.");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (sign == 1)
            {
                Console.WriteLine(number + " + " number2 + " = " number + number2);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("fuck you")
            }




        }
    }
}
