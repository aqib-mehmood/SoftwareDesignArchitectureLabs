using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab05
{
     class Ringtone : FLDecorator
    {
         public Ringtone() { }
       
        public Ringtone(IFlashLight decorated_function) 
        {
            this.decorated_function = decorated_function;
            
        }
        
       
        public void new_basic_function()
        {
            //decorated_function.basic_function();
            set_rigntone();

        }
        public void set_rigntone() 
        {
            Console.WriteLine("Rigntone has been added.\n");
        }

    }
}
