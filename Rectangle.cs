using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Rectangle
    {
        private float length;
        private float width;

        public Rectangle(float length, float width) 
        {
            this.length = length;
            this.width = width;
        }
        public float Length { get { return length; } }
        public float Width { get { return width; } }    

        public float CalculateArea()
        {
            return length * width;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Rectangle Length: {length}");
            Console.WriteLine($"Rectangle Width: {width}");
            Console.WriteLine($"Area of rectangle: {CalculateArea()}");
        }

    }
}
