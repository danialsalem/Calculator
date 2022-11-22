using System;
using System.Diagnostics;

namespace Advcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int num1, num2,  choice, asign;
                bool isCondition=false;
                string op;
            double result = 0;
                Console.WriteLine("Calculator"+"\n");
                Console.Write("Enter Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                asign = num1;
                Console.Write("Enter Operator:");
                op = Console.ReadLine();
                Console.Write("Enter Number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Do you want to proceed (Yes:1/No:2) :");
                choice = Convert.ToInt32(Console.ReadLine());
                   
                if (choice == 1)
                {
                    isCondition = true;
                }
                else
                    if (choice == 2)
                {
                    isCondition = false;
                    if (op == "+")
                    {
                        result = asign + num2; 
                    }
                    else if (op == "-")
                    {
                        result = asign - num2; 
                    }
                    else if (op == "*")
                    {
                        result = asign * num2; 
                    }
                    else if (op == "/")
                    {
                        result = asign / num2;
                    }
                    
                    Console.WriteLine("Result is: " + result);
                }
                else
                    {
                        Console.WriteLine("Invalid Operation!! ");
                    }
                
            } while (isCondition);
            
        }
    } 
    
}
       