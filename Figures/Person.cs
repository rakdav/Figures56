using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Person : IMovable
    {
        public void Eat()
        {
            Console.WriteLine("Питаться хлебом"); ;
        }

        public void Move()
        {
            Console.WriteLine("Двигаься быстро"); ;
        }

        public void Sleep()
        {
            Console.WriteLine("Спать 8 часов"); ;
        }
    }
}
