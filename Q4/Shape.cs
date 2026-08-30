using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeManagement
{
    public class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            this.Name = name;
        }
        public virtual decimal CalcArea()
        {
            return 0;
        }

        public override string ToString()
        {
                return $"Shape: {Name}" +
                $"\nArea: {Math.Round(CalcArea(), 2):N2}";

        }
    }
}
