using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab06
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlAdaptee adapte = new XmlAdaptee();
            ITarget target = new JsonAdapter(adapte);
            Console.WriteLine("Adaptee interface is incompatible with the client");
            Console.WriteLine("So by using adapter client can call its method");
            Console.WriteLine("\nAfter using Adapter Design Pattern, we get the requested data below");
            Console.WriteLine(target.GetRequest());
            Console.WriteLine("So we get the converted data..\n");
        }
    }
}
