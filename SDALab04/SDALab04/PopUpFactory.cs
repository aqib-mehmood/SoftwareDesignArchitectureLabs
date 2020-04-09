using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class PopUpFactory
    {
        public InterfacePopups factory(string option)
        {

            if (option == "1")
            {
                Console.WriteLine("Warning: This is  Alert");
                return new Alert();

            }
            else if (option == "2")
            {
                Console.WriteLine("This is MOdal.");
                return new Modal();

            }
            else
            {

                return null;
            }

        }

    }
}
