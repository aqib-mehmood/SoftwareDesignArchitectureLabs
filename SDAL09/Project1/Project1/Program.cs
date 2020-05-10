using Accounting_Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation _cal = new Calculation();
            _cal.Marks_input();
            _cal.dislay();
            
        }
    }
}
