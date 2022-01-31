using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionDemo;
using System.Reflection;

namespace DemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Pen);
            MemberInfo[] members = type.GetMembers();
            foreach(MemberInfo mi in members)
            {
                Console.WriteLine($"{mi.Name}------>{mi.MemberType}");
            }
            Console.WriteLine($"----------------");
            //Console.WriteLine($"Name is {type.Name}");
            //Console.WriteLine($"Full Name is {type.FullName}");
            //Console.WriteLine($"Assembly info is {type.Assembly.ToString()}");
            //Pen p = new Pen();
            //    Console.WriteLine(  $"Name is {p.GetType().Name}");
            //Console.WriteLine($"Full Name is {p.GetType().FullName}");
            //Console.WriteLine($"Assembly info is {p.GetType().Assembly.ToString()}");

        }
    }
}
