using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab05
{
     abstract class FLDecorator : IFlashLight
    {
        public IFlashLight decorated_function;
        public FLDecorator() { }
        public FLDecorator(IFlashLight decorated_function) 
        {
            this.decorated_function = decorated_function;
    
        }
        public void basic_function()
        {
            decorated_function.basic_function();
        }
    }
}
