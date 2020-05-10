using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting_Module;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Code resue--------------");
            Calculation _obj = new Calculation();
            _obj.Marks_input();
            _obj.dislay();
            Console.WriteLine("Good Bye!");
            Console.ReadKey();
        }
    }
}
