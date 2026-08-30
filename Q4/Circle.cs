using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeManagement
{
    public class Circle : Shape //area= PI (R squared)
    {
        public decimal Radius {  get; set; }
        public Circle(decimal radius) : base("Circle")
        {
            this.Radius = radius;
        }

        public override decimal CalcArea()//helper
        {
            return CalcCircleArea();
        }
        private decimal CalcCircleArea()
        {
            return (decimal)Math.PI * Radius * Radius;//math.pi= 3.141592... decimal pi value
        }


    }
}
