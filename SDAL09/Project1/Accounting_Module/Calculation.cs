using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Module
{
    public class Calculation
    {
        double total = 0;
        double gpa = 0;
        double crdt = 0;
        double Percentage = 0;
        public void Marks_input()
        {
            Console.WriteLine("------------Mark Sheet----------");
            Console.Write("Total Crdt hr. = ");
            crdt = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of Each subject given below:");
            Console.Write("1-SDA : ");
            double sda = int.Parse(Console.ReadLine());
            Console.Write("2-DBMS : ");
            double dbms = int.Parse(Console.ReadLine());
            Console.Write("3-OS : ");
            double os = int.Parse(Console.ReadLine());
            Console.Write("4-PSY : ");
            double psy = int.Parse(Console.ReadLine());
            Console.Write("5-Probability : ");
            double probab = int.Parse(Console.ReadLine());
            Total_Marks(sda, dbms, os, psy, probab);

        }
        public void Total_Marks(double sda, double dbms, double os, double psy, double prob)
        {
            total = sda + dbms + os + psy + prob;
            Percentage = (total / 500)*100;
            if (Percentage<=50)
            {
                gpa = 0;
            }
            else if (Percentage>50 && Percentage<=65)
            {
                gpa = 2.0;
            }
            else if (Percentage > 65 && Percentage <= 75)
            {
                gpa = 3.0;
            }
            else if (Percentage > 75 && Percentage <= 85)
            {
                gpa = 3.67;
            }
            else
            {
                gpa = 4.0;
            }
        }
        
        public void dislay()
        {
            Console.WriteLine("Total Marks out of 500 = {0}",total);
            Console.WriteLine("GPA = {0}",gpa);
        }
 
    }
}
