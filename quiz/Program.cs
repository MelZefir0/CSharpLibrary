using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle(12, 100);
            Triangle triTwo = new Triangle(17, 30);
            Triangle triThree = new Triangle(6, 300);
            Triangle triFour = new Triangle(18, 47);


            Console.WriteLine($"Area = {newTriangle.Area()}");
            Console.WriteLine($"Area = {triTwo.Area()}");
            Console.WriteLine($"Area = {triThree.Area()}");
            Console.WriteLine($"Area = {triFour.Area()}");
            Console.ReadLine();
        }
    }
}
