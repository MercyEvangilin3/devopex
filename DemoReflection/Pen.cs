using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoReflection;
//This is git demo
namespace CollectionDemo
{
    [Info (Name ="Tom",Age = 25)]
    [Info (Name = "dhs",Age =24)]
    class Pen : IComparable
    {
        public delegate void RateHandler(string msg);
        public event RateHandler RateChange;//rate of change is the name of the event
        public void NewRate(int rate)

        {
            int oldrate = this.Rate;
            this.Rate = rate;
            if (RateChange != null)
            RateChange($"Rate of pen chaged from {oldrate} to {rate}");
        }

        
          public int Rate { get; set; }
        public string color { get; set; }
        public int CompareTo(object obj)
        {
            //Pen p = obj as Pen;
            //return string.Compare(this.color, p.color);
            Pen p = obj as Pen;
            if (this.Rate > p.Rate) return -1;
            else if (this.Rate < p.Rate) return 1;
            else return 0;
        
        }
        public override string ToString()
        {
            return $"{Rate}, {color}";
        }

        public void Add(int x, int y)
        {
            Console.WriteLine($"Add = {x+y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply = {x * y}");
        }

        public void Subs(int x, int y)
        {
            Console.WriteLine($"Subs = {x - y}");
        }


    }



}
