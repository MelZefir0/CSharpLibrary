using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_13_GettersStarters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmp = new Employee();

            Console.WriteLine("Enter employee name: ");
            newEmp.Name = Console.ReadLine();

            Console.WriteLine("Enter emplyoee ID: ");
            newEmp.ID = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"New emplyee is: {newEmp.Name} {newEmp.ID}");

            Console.WriteLine($"Enter common quote for {newEmp.Name}");

            Console.WriteLine("");
        }
    }
}
