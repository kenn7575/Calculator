using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                double num1, num2;


                num1 = GetInputAndConvertToDouble("Enter first number: ");

                num2 = GetInputAndConvertToDouble("Enter second number: ");
                string mode = "";
                bool valid = false;
                while(!valid)
                {
                     Console.WriteLine("Choose an option (+, -, *, /, %): ");
                     mode = Console.ReadLine();
                     if (new[] {"+", "-", "/", "*", "%"}.Contains(mode))
                     {
                        valid = true;
                     }
                     else
                    {
                        Console.Write("Invalid operation! Try again ");
                    }
                }
               
                switch (mode)
                {
                    case "+":
                        Console.WriteLine("{1} + {2} is {0}", (num1 + num2), num1, num2);
                        break;
                    case "-":
                        Console.WriteLine("{1} - {2} is {0}", (num1 - num2), num1, num2);
                        break;
                    case "*":
                        Console.WriteLine("{1} * {2} is {0}", (num1 * num2), num1, num2);
                        break;
                    case "/":
                        Console.WriteLine("{1} / {2} is {0}", (num1 / num2), num1, num2);
                        break;
                    case "%":
                        Console.WriteLine("The remainder of {1} devited by {2} is {0}", (num1 % num2), num1, num2);
                        break;
                        
                }
                Console.ReadKey();
            }
            
        }
        static double GetInputAndConvertToDouble(string message)
        {
            bool valid = false;
            double output_value = 0;
            while (!valid)
            {
                Console.WriteLine(message);
                string input_value = Console.ReadLine();
                bool result = Double.TryParse(input_value, out output_value);
                if (result)
                {
                    valid = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error: could not convert {0} to int", input_value);
                }
            }
            return output_value;
        }
    }
}
