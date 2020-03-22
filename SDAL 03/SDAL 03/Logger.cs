using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDAL_03
{
    class Logger
    {
        protected static Logger _obj; 
        private Logger() { }       
        public static Logger GetObject() 
        {
            if (_obj == null) 
        { 
            _obj = new Logger(); 
        } 
            return _obj; 
        }
        public void Printer(int num) 
        {
            Console.WriteLine("{0} Logger app are connected or exist:",num);
            Console.WriteLine("Enter Name of logs!");
            string[] name = new string[num];
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("Each logs in a Sequence");
            for (int j = 0; j < name.Length; j++)
            {
                Console.WriteLine("Date n Time : {2} : Log {0} = {1}",j,name[j],DateTime.Now);
            }
        }
        
        public void Print(string s) 
        { 
            Console.WriteLine(s); 
        }


        //private static Logger _obj = null;
        //private Logger() {}
        //public static Logger GetObject() 
        //{
        //    if (_obj == null) 
        //    {
        //        _obj = new Logger();
        //    }
        //    return _obj;
        //}
        //public void Print_Log(string message)
        //{
        //    Console.WriteLine("[{0}]: {1}",DateTime.Now,message);
        //}
    }
}
