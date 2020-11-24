using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Figure
    {
        public string Name { get; set; }

        protected Figure(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimetr();
    }
}
