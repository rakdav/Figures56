using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Окружность", 5);
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimetr());

            Rectangle rext = new Rectangle("Прямоугольник",30,40);
            Console.WriteLine(rext.Area());
            Console.WriteLine(rext.Perimetr());

            Person person = new Person();
            person.Eat();
            person.Move();
            person.Sleep();

            Tiger tiger = new Tiger();
            tiger.Eat();
            tiger.Move();
            tiger.Sleep();
            Console.ReadKey();
        }
    }
}
