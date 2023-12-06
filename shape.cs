using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    // Base class
    public class Shape
    {
        public virtual int CalculateArea()
        {
            return 0;
        }
    }

    // Derived class
    public class Circle : Shape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int CalculateArea()
        {
            //type casting into integer because the return type of the overriden function is int
            var area = (int)(3.14 * radius * radius);
            Console.WriteLine("The area for given radius " + area);
            return area;
        }
    }
}
