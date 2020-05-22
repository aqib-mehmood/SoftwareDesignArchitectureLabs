using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab11Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|--------------Calculator--------------|");
            Console.WriteLine("Enter Two NUmbers for Performing Calculation");
            Console.Write("Enter Number 1 : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            double num2 = double.Parse(Console.ReadLine());
            Calculator obj = new Calculator(num1, num2);
            
            while (true)
            {
                Console.WriteLine("Now what action you want to perform");
                Console.WriteLine("1-Add\n2-Subtract\n3-Multiply\n4-Divide\n0-Exit");
                int opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine("Addition of {0} + {1} = {2}",num1,num2,obj.add());
                    
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Subtraction of {0} - {1} = {2}", num1, num2, obj.subtract());
                }
                else if (opt == 3)
                {
                    Console.WriteLine("Multiplication of {0} * {1} = {2}", num1, num2, obj.multiply());
                }
                else if (opt == 4)
                {
                    Console.WriteLine("Division of {0} / {1} = {2}", num1, num2, obj.divide());
                }
                else if (opt==0)
                {
                    Console.WriteLine("Successfully Exit..Good Byee..");
                    Environment.Exit(0);
                }
            }
            
        }

    }
}
