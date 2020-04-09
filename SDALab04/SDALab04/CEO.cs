using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class CEO:Rank
    {
        public String emp_name
        {
            get { return "CEO "; }

        }
        public int emp_id
        {
            get { return 2; }

        }
        public int emp_age
        {
            get { return 25; }
        }
        public String emp_CNIC
        {
            get { return "2222-3311-2002"; }

        }
        public double salary()
        {

            return 584000;

        }

    }
}
