using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab05
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlashLight flash_obj = new FlashLight();
            IFlashLight ring_obj = new Ringtone(new FlashLight());
            IFlashLight obj_1 = new Ringtone(new FlashLight());
            FLEffect effect_obj = new FLEffect();
            Ringtone ringtone_obj = new Ringtone();
            Console.WriteLine("Basic Functionality of Flash Light:");
            flash_obj.basic_function();
            Console.WriteLine("\nAfter decorating with rigntone:");
            ringtone_obj.new_basic_function();
            Console.WriteLine("\nAfter decorating with flashlight effect:");
            effect_obj.new_basic_function();
            
        }
    }
}
