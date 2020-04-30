using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab05
{
    class FLEffect : FLDecorator
    {
        public FLEffect() { }
        public FLEffect(IFlashLight decorated_function)
        {
            this.decorated_function = decorated_function;
            
        }
        public void new_basic_function()
        {
            //decorated_function.basic_function();
            set_FL_effect();
        }
        private void set_FL_effect()
        {
            Console.WriteLine("Flash Light has been added.\n");
        }
    }
}
