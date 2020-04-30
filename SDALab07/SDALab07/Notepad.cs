using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class Notepad : Processing
    {
        public override void ProcessRequest(int input)
        {
            if (input.Equals(2))
            {
                Console.WriteLine("Notepad is Opening");
                Console.WriteLine("Now you can write content");
            }
            else
            {
                Console.WriteLine("Sorry Try again");
            }
        }
    }
}
