using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class CallOperator : CallCenter
    {

        public override void ProcessRequest(int input)
        {
            if (input.Equals(1))
            {
                Console.WriteLine("You are welcome to call center\nHow may i help you");
            }
            else if (input.Equals(2))
            {
                Console.WriteLine("Your call is transferring to HeadQuarter.");
                Headquarter head = new Headquarter();
                head.ProcessRequest(1);
            }
            else if (input.Equals(3))
            {
                Console.WriteLine("To avail this offer Your balance is low sorry Recharge and Try again");
            }
        }
    }
}
