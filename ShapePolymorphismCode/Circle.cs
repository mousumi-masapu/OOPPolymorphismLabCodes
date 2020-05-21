using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ShapeCalculation
{
   public class Circle :Shape
    {
        private double radius;
    
    public Circle (double radius)
    {
        this.radius = radius;
    }
        public override double CalculateArea()
        {
            return Math.PI * (this.radius * this.radius);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
        public override string Draw()
        {
            return "Circle";
        }
    }
}
