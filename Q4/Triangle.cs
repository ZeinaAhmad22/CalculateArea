using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeManagement
{
    public class Triangle : Shape //area= base*height /2
    {
        public decimal Base {  get; set; }
        public decimal Height { get; set; }
        public Triangle(decimal trianglebase, decimal height) : base("Triangle")
        {
            this.Base=trianglebase;
            this.Height=height;
        }
        public override decimal CalcArea()//helper
        {
            return CalcTriangleArea();


        }
        public decimal CalcTriangleArea()
        {
            return (Base * Height) / 2;
        }
    }
}
