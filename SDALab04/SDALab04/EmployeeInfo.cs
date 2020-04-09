using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class EmployeeInfo:Manager
    {
        public Rank getInfo(String getinfo)
        {

            if (getinfo == "1")
            {
                return new Manager();
            }
            else if (getinfo == "2")
            {

                return new CEO();
            }

            else
            {
                return null;
            }
        }

    }
}
