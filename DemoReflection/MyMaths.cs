using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflection
{
    public class MyMaths
    {
        public int Fno { get; set; } //properties
        public int sno { get; set; }//properties
        public int Add()//method
        {
            return Fno + sno;
        }
        public int Multiply(int x,int y)
        {
            return x * y;
        }
    }
}
