using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Triangle : Shape
    {
        

        //Constructor
        public Triangle(int TBase, int THeight)
        {
            this.TBase = TBase;
            this.THeight = THeight;
        }

        //Properties
        public int TBase { get; set; }
        public int THeight { get; set; }

        //Method
        public override double Area()
        {
            return this.TBase * this.THeight / 2.0;
        }
    }
}
