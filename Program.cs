using System;

namespace MathConsole
{
    internal class Program
    {
        /// <summary>
        /// main, asks user for 2 numbers and performs various computations
        /// </summary>
        static void Main()
        {
            int number1; //first number
            int number2; //second number
            int sum, difference, product, quotient, remainder; //for various math computations

            //prompt first number
            Console.Write("Please enter the first number: ");
            //receive input for first number
            number1 = int.Parse(Console.ReadLine());

            //prompt second number
            Console.Write("Please enter the second number: ");
            //receive input for second number
            number2 = int.Parse(Console.ReadLine());

            //extra print for spacing/sanity check
            Console.WriteLine();

            //show output for math (add, sub, div, mult, mod)
            //Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;
            remainder = number1 % number2;

            Console.WriteLine(number1 + " + " + number2 + " = " + sum); // print addition
            Console.WriteLine(number1 + " - " + number2 + " = " + difference); // print subtraction
            Console.WriteLine(number1 + " * " + number2 + " = " + product); // print product
            Console.WriteLine(number1 + " / " + number2 + " = " + quotient); // print quotient
            Console.WriteLine(number1 + " % " + number2 + " = " + remainder); // print remainder

            //extra line for spacing/sanity
            Console.WriteLine();

            //comparison
            if(number1 < number2) //less than
            {
                Console.WriteLine($"{number1} is less than {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is not less than {number2}");
            }

            if(number1 > number2)//greater than
            {
                Console.WriteLine($"{number1} is greater than {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is not greater than {number2}");
            }

            if(number1 == number2)//equals
            {
                Console.WriteLine($"{number1} equals {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} does not equal {number2}");
            }

        }
    }
}