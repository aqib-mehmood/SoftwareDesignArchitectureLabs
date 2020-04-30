using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class MediaPlayer : Processing
    {

        public override void ProcessRequest(int input)
        {
            if (input.Equals(3))
            {
                Console.WriteLine("Your Favourite Media Player is Opening..");
                Console.WriteLine("Play selected songs from list");
            }
            else
            {
                Console.WriteLine("Sorry Try again");
            }
        }
    }
}
