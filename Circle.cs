﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEG_324_Abrstract_Class_Assignment
{
    public class Circle : Shape
    {
        public Circle(double Radius) : base(Radius)
        {


        }
        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(width, 2);
        }
    }
}
