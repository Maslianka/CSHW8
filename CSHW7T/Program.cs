using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW7T
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("sqr1",2));
            shapes.Add(new Square("sqr2", 5));
            shapes.Add(new Square("sqr3", 3));

            shapes.Add(new Circle("cir1", 28));
            shapes.Add(new Circle("cir2", 7));
            shapes.Add(new Circle("cir3", 9));
            Shape per = shapes[0];
            foreach (var d in shapes)
            {
                Console.WriteLine( $"Type {d.GetType().Name} \nPerimeter = {d.Perimeter()}'inch, Area = {d.Area()} \nName of shape - {d.Name}\n");
                //if (per.Perimeter() < d.Perimeter())
                //{
                //    per = d;
                //}
            }
            Console.WriteLine(per.Name);
            Console.ReadLine();
        }
    }
}
