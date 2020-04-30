using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class Calculator : Processing
    {
        public override void ProcessRequest(int input)
        {
            if (input.Equals(4))
            {
                Console.Write("Calculator : ");
                Console.WriteLine("You can perform calculation");
            }
            else
            {
                Console.WriteLine("Sorry Try again");
            }
        }
    }
}
