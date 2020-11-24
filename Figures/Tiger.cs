using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Tiger : IMovable
    {
        public void Eat()
        {
            Console.WriteLine("Мясо"); ;
        }

        public void Move()
        {
            Console.WriteLine("Очень быстро"); ;
        }

        public void Sleep()
        {
            Console.WriteLine("16 часов"); ;
        }
    }
}
