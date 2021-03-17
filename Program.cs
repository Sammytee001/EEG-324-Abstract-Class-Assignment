using EEG_324_Abrstract_Class_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEG_324_Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 5);
            Rectangle rectangle = new Rectangle(2, 2);
            Circle circle = new Circle(5);


            Console.WriteLine("Area of Triangle: {0}", triangle.CalculateSurface());
            Console.WriteLine("Area of Rectangle: {0}", rectangle.CalculateSurface());
            Console.WriteLine("Area of Circle: {0}", circle.CalculateSurface());


            Console.ReadLine();
        }
    }
}
