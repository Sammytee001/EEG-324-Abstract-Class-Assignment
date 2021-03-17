using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEG_324_Abrstract_Class_Assignment
{
    public class Rectangle : Shape
    {
        public Rectangle(double Width, double Height) : base(Width, Height)
        {


        }
        public override double CalculateSurface()
        {
            return height * width;
        }
    }
}
