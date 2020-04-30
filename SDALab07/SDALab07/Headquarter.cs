using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class Headquarter : CallCenter
    {

        public override void ProcessRequest(int input)
        {
            if (input.Equals(1))
            {
                Console.WriteLine("You are connected to head quarter");
                Console.WriteLine("Welcome to Call Center HeadQuarter");
            }
            else 
            {
                Console.WriteLine("Sorry Try again");
            }
        }
    }
}
