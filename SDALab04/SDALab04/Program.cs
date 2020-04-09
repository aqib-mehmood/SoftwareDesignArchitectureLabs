using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab04
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------Task 02----------------
            /* Console.WriteLine("Select One: \n1)Manager: \n2)CEO:");
             String opt4 = Console.ReadLine();
             EmployeeInfo info = new EmployeeInfo();
             Rank rank = info.getInfo(opt4);
             rank.salary();
             Console.WriteLine("Employee ID: {0}", rank.emp_id);
             Console.WriteLine("Emplpyee Name: {0}", rank.emp_name);
             Console.WriteLine("Employee Identity No. {0}", rank.emp_CNIC);
             Console.WriteLine("Employee Age: {0}", rank.emp_age);
             Console.WriteLine("Employee Salary: {0}", rank.salary());
             */
            //-----------------Task 01----------------
            WebFactory obj_web = new WebFactory();
            PopUpFactory obj_pop = new PopUpFactory();
            Console.WriteLine("What do you want to visit :\n1)Website:\n2)Popups:");
            String opt0 = Console.ReadLine();
            if (opt0 == "1")
            {
                obj_web.getWeb();
            }
            else if (opt0 == "2")
            {
                Console.WriteLine("Enter option: \n1)Alerts: \n2)Modal:");
                String opt1 = Console.ReadLine();
                obj_pop.factory(opt1);
            }
            else 
            {
                Console.WriteLine("Inavalid Input.\nTry Again");
            }
        }
    }
}
