﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle:Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name,double width, double height):base(name)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width*Height;
        }

        public override double Perimetr()
        {
            return 2 * (Width + Height);
        }
    }
}
