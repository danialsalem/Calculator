using System;
using System.Reflection;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Calculator" + "\n");

                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Modulus");
                Console.WriteLine("5.Square Rooot");
                Console.WriteLine("6.Square");
                Console.WriteLine("7.Power");
                Console.WriteLine("Select Operation");
                int ovalue = Convert.ToInt32(Console.ReadLine());
                double fvalue, svalue, r;
                double mvalue;

                switch (ovalue)
                {
                    case 1:
                        Console.WriteLine("Enter First Value: ");
                        fvalue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Second Value: ");
                        svalue = Convert.ToDouble(Console.ReadLine());
                        r = fvalue + svalue;
                        Console.WriteLine("Addition: " + r);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Value: ");
                        fvalue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Second Value: ");
                        svalue = Convert.ToDouble(Console.ReadLine());
                        r = fvalue - svalue;
                        Console.WriteLine("Subtraction: " + r);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Value: ");
                        fvalue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Second Value: ");
                        svalue = Convert.ToDouble(Console.ReadLine());
                        r = fvalue * svalue;
                        Console.WriteLine("Multiplication: " + r);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Value: ");
                        fvalue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Second Value: ");
                        svalue = Convert.ToDouble(Console.ReadLine());
                        r = fvalue % svalue;
                        Console.WriteLine("Modulus: " + r);
                        break;
                    case 5:
                        Console.WriteLine("Enter Value: ");
                        mvalue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Square Rooot: " + Math.Sqrt(mvalue));
                        break;
                    case 6:
                        Console.WriteLine("Enter Value: ");
                        fvalue = Convert.ToDouble(Console.ReadLine());
                        r = fvalue * fvalue;
                        Console.WriteLine("Square: " + r);
                        break;
                    case 7:
                        Console.WriteLine("Enter Value for power: ");
                        fvalue = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter power: ");
                        svalue = Convert.ToDouble(Console.ReadLine());
                        double pow_ab = Math.Pow(fvalue, svalue);
                        Console.WriteLine("Square Rooot: " + pow_ab);
                        break;

                    default:
                        Console.WriteLine("Invalid Operation!!");
                        break;
                }
                Console.WriteLine("Do you want to Continue press y press n for Exit: " );
                choice=Console.ReadLine();
            }
            while (choice=="y");
        }
    }
}
