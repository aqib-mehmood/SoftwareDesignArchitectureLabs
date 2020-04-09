using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class Home:InterfaceWebsite
    {
        public string WebSiteName
        {
            get { return "WebFactory"; }
        }

        public void Web_Home()
        {
            Console.WriteLine("This is Home Page.");
            Console.WriteLine("You are on Home Page");

        }
    }
}
