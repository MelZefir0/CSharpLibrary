using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_00LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array of instructors
            string[] instructors = {"dsa","dsvfds", "dfd", "no" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop through the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1,Name="John Boy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=2,Name="John Boy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=3,Name="John Boy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=4,Name="John Boy",HireDate=new DateTime(2015,3,5)}
            };
            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2016
                                             select e;
            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }
            Console.ReadLine();
        }
    }
    
}
