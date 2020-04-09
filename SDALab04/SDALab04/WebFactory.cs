using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class WebFactory
    {
        public InterfaceWebsite getWeb()
        {

                Console.WriteLine("Slect one \n1)Home Page:\n2)ContactUs Page:");
                int opt1 = int.Parse(Console.ReadLine());
                if (opt1 == 1)
                {
                    Console.WriteLine("This is Home Page.");
                    Console.WriteLine("You are on Home Page");
                    return new Home();
                }
                else if (opt1 == 2)
                {
                    Console.WriteLine("This is a Contact us page");
                    Console.WriteLine("Good Bye...");
                    return new Contact();
                }
            
            return null;
            
        }
    }
}
