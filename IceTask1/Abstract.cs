using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IceTask1
{
    public abstract class Shape
    {
        public string Name { get; set; }  // Property for name

        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
