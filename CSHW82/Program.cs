using CSHW7T;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW82
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create list of Shape and fill it with 6 different shapes(Circle and Square).
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("sqr1", 1));
            shapes.Add(new Square("sqr2", 5));
            shapes.Add(new Square("sqr3", 1));

            shapes.Add(new Circle("cir1", 28));
            shapes.Add(new Circle("cira2", 7));
            shapes.Add(new Circle("cir3", 9));
            #endregion

            #region Find and write into the file shapes with area from range[10, 100]
            foreach (var d in shapes.Where(x => x.Area() >= 10 && x.Area() <= 100))
            {
                Console.WriteLine($"Type {d.GetType().Name} \nPerimeter = {d.Perimeter()}'inch, Area = {d.Area()} \nName of shape - {d.Name}\n");
            }
            #endregion


            #region Find and write into the file shapes which name contains letter 'a'
            Console.WriteLine("\n\n");
            foreach (var d in shapes.Where(x => x.Name.Contains('a')))
            {
                Console.WriteLine($"Type {d.GetType().Name} \nPerimeter = {d.Perimeter()}'inch, Area = {d.Area()} \nName of shape - {d.Name}\n");
            }
            #endregion


            #region Find and remove from the list all shapes with perimeter less then 5.   
            Console.WriteLine("\n\n");
            foreach (var d in shapes.Where(x => x.Perimeter() < 5))
            {
                Console.WriteLine($"Type {d.GetType().Name} \nPerimeter = {d.Perimeter()}'inch, Area = {d.Area()} \nName of shape - {d.Name}\n");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
