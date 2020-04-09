using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class Contact:InterfaceWebsite
    {
        public string WebSiteName
        {
            get { return "WebFactory"; }
        }
        public void Contactus()
        {
            Console.WriteLine("This is a Contact us page");
            Console.WriteLine("Good Bye...");

        }

    }
}
