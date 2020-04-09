using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class Manager:Rank
    {
        public String emp_name {
            get { return "AQIB MEHMOOD"; }
        
        }
       public int emp_id
        {
            get { return 1; }

        }
        public String emp_CNIC
        {
            get { return "13345-45578641-2"; }

        }
        public int emp_age { 

            get { return 20; } 

        }
        public double salary()
        {

            return 2000;
        }
    }

}
