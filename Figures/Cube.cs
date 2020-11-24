using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Cube : _I3D
    {
        public double X {get;set;}
        public double Y { get; set; }
        public double Z { get; set; }
        public double Area()
        {
            return 2*(X+Y)*Z;
        }

        public double Perimetr()
        {
            return 4 * (X + Y) * 4 * Z;
        }

        public double Volume()
        {
            return X*Y*Z;
        }
    }
}
