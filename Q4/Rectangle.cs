using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeManagement
{
    public class Rectangle : Shape //area= width*height
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Rectangle(decimal width, decimal height) : base("Rectangle")
        {
            this.Width = width;
            this.Height = height;
        }
        public override decimal CalcArea()//helper
        {
            return CalcRectangleArea();
        }
        private decimal CalcRectangleArea()
        {
            return Width * Height;
        }
    }
}
