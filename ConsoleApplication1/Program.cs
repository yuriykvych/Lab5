using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! My name is ...");
            String s = Console.ReadLine();
            s = "Hello, " + s + ".";
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
