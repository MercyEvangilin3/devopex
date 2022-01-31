using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoReflection
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]//true is which give sthe multiple attributes
    class Info : Attribute//info about customer Attribute
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    
}
