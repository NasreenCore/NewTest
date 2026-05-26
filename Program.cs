using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am going to test the git repository...");
            Console.WriteLine("I WANT TO BE EXPERT IN AZURE");
            Console.WriteLine("happy to see it");
            Calculation obj=new Calculation();
           Console.Write( obj.WorkDone1(8, 6));
            Employee empObj=new Employee();
            Console.WriteLine("Employee salary is"+empObj.CalSalary(9000));
        }
    }
}
