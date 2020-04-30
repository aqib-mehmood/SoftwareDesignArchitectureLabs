using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    abstract class CallCenter
    {
        protected CallCenter successor;
        public void SetSuccessor(CallCenter successor) 
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(int input);
    }
}
