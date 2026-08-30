using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>//a list for all the shapes
            {
                new Circle(5),
                new Rectangle(4,6),
                new Triangle(3,8)
            };
            foreach (Shape shape in shapes)//loop to calculate every shape in the list 
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine();
            }
        }
    }
}