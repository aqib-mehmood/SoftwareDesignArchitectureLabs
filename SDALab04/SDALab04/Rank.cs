using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    interface Rank
    {
        String emp_name { get; }
        int emp_age { get; }
        double salary();
        int emp_id { get; }
        String emp_CNIC { get; }
    }
}
