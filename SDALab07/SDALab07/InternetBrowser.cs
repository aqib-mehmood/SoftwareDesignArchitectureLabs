using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class InternetBrowser : Processing
    {

        public override void ProcessRequest(int input)
        {
            if (input.Equals(1))
            {
                Console.WriteLine("Your Requested Browser is opening");
                Console.WriteLine("Welcome to Firefox");
            }
            else
            {
                Console.WriteLine("Sorry Try again");
            }
        }
    }
}
