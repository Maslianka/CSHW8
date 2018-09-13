using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW7T
{
    public abstract class Shape
    {
        public Shape(string _name)
        {
            name = _name;
        }
        string name;
        public string Name { get; set; }
        public abstract double Area();
        public abstract double Perimeter(); 
    }
}
