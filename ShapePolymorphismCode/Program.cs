using System;

namespace ShapeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the rectangle");

            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");

            double width = double.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(height, width);

            double rectArea = rect.CalculateArea();

            double rectPerimeter = rect.CalculatePerimeter();

            string rectShape = rect.Draw();

            Console.WriteLine("The {0} area is {1} and the perimeter is {2} ", rectShape, rectArea, rectPerimeter);

            Console.WriteLine("Enter the radius of the circle");

            double radius = double.Parse(Console.ReadLine());

            Circle cir = new Circle(radius);

            double cirectArea=cir.CalculateArea();

            double cirPerimeter=cir.CalculatePerimeter();

            string cirShape = cir.Draw();
            
            Console.WriteLine("The {0} area is {1} and the perimeter is {2} ", cirShape,cirectArea, cirPerimeter);
            
            Console.ReadLine();

        }
    }
}
