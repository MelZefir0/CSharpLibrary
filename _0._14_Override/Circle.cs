using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Circle : Shape
    {
        //Constants
        public const double RADIUS = 3.14;

        //Constructor
        public Circle(int radius)
        {
            this.Radius = Radius;
        }

        //Properties
        public int Radius { get; set; }

        //Methods
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }
    }
}
