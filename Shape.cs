using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        public float radius;
        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float Radius { get { return radius; } }
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Radius of circle: {radius}");
            Console.WriteLine($"Area of Circle: {CalculateArea()}");
        }

    }
}
