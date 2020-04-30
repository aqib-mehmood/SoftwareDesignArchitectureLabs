using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDALab06
{
    class JsonAdapter : ITarget
    {
        private readonly XmlAdaptee _adaptee;
        public JsonAdapter(XmlAdaptee _adaptee) 
        {
            this._adaptee = _adaptee;
        }
        public string GetRequest() 
        {
            return this._adaptee.GetSpecificRequest();

        }
    }
}
