using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab11Task01
{
    class Calculator
    {
        double a;
        double b;
        
        public Calculator() { }
        public Calculator(double num1,double num2) 
        {
            this.a = num1;
            this.b = num2;
        }

        public double add()
        {
            return a + b;
        }
        public double subtract()
        {
            return a - b;
        }
        public double multiply()
        {
            return a * b;
        }
        public double divide()
        {
            return a / b;
        }
    }
}
