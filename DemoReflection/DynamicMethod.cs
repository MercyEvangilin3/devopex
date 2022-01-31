using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoReflection
{
    class DynamicMethod
    {
         static void Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();//innformation about this assembly
            Type type = assembly.GetType("DemoReflection.MyMaths");
            object objMath = assembly.CreateInstance("DemoReflection.MyMaths");
            PropertyInfo[] properties = type.GetProperties();//propertyinfo gives information about properties.
            properties[0].SetValue(objMath,70);
            properties[1].SetValue(objMath, 80);
            MethodInfo method = type.GetMethod("Add");
            int result = (int)method.Invoke(objMath, null);
            Console.WriteLine($"Add -{result}");
            MethodInfo method1 = type.GetMethod("Multiply");
            int result1 = (int)method1.Invoke(objMath,new object[] { 4, 12 });
            Console.WriteLine($"Multiply - {result1}");


        }
    }
}
