using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string username = Console.ReadLine();

            Console.WriteLine("Hello, {0} the current time is {1}", username, System.DateTime.Now.TimeOfDay);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();

        }
    }
}
