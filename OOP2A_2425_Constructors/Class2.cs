using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2A_2425_Constructors
{
    internal class Class2
    {
        private int a = 5;

        public Class2()
        {

        }

        public Class2(int val)
        {
            a = val;
        }

        public void DisplayA()
        {
            Console.WriteLine($"The value of a is {a}");
        }
    }
}
