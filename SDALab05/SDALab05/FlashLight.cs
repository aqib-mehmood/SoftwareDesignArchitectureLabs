using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab05
{
     class FlashLight : IFlashLight
    {
         public FlashLight() { }

        public void basic_function()
        {
            Console.WriteLine("Basic Functionality -> only flash light.");

        }
    }
}
