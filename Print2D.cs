using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public struct Print2D
    {
        public float x;
        public float y;

        public static float CalculateDistance(Print2D p1, Print2D p2)
        {
            return (float)Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 20));
        }
    }


}
