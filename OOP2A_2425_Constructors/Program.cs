using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2A_2425_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();
            Class2 b = new Class2(24);
            Class2 c = new Class2();

            a.a = 24;
            a.DisplayA();
            b.DisplayA();
            c.DisplayA();

            Console.ReadKey();
        }
    }
}
