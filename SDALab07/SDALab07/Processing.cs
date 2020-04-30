using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab07
{
    abstract class Processing
    {
        public Processing() { }
        protected Processing NextLogger;
        public Processing(Processing NextLogger) 
        {
            this.NextLogger = NextLogger;
        }

        public abstract void ProcessRequest(int input);

        
    }
}
