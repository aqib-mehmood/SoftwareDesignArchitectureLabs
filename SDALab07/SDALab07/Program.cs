using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////-------Task 02-------//////////////////////////////////
            /*CallCenter asher = new CallOperator();
            CallCenter head = new Headquarter();
            asher.SetSuccessor(head);
            Console.WriteLine("Please Select one from following:");
            Console.WriteLine("1-Greeting\n2-Call Center Head Quarter\n3-Availing Offers");
            int inp = int.Parse(Console.ReadLine());
            if (inp==1)
            {
                asher.ProcessRequest(inp);
            }
            else if (inp == 2)
            {
                asher.ProcessRequest(inp);
            }
            else if (inp==3)
            {
                asher.ProcessRequest(inp);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            */
            //////////////////////////-------Task 01-------//////////////////////////////////

            Processing obj_internet = new InternetBrowser();
            Processing obj_notpad = new Notepad();
            Processing obj_media = new MediaPlayer();
            Processing obj_calc = new Calculator();
            Console.WriteLine("What do you want to open:\n Select one from following:");
            Console.WriteLine("1-Internet Browser\n2-Notepad\n3-MediaPlayer\n4-Calculator");
            int inp = int.Parse(Console.ReadLine());
            if (inp == 1)
            {
                obj_internet.ProcessRequest(inp);
            }
            else if (inp == 2)
            {
                obj_notpad.ProcessRequest(inp);
            }
            else if (inp == 3)
            {
                obj_media.ProcessRequest(inp);
            }
            else if (inp == 4)
            {
                obj_calc.ProcessRequest(inp);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }
    }
}
