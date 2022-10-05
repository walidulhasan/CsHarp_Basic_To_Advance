using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsHarp_Basic_To_Advance_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string print = "Hello World";
            int number = 10;
            float floatNumber = 10.4f;
            double doubleNumber = 10.40;
            decimal decimalNumber = 30.45m;
            bool isTrue = false;
            //byte thisByte = 2223241242;

            Console.WriteLine($"String: {print}\n{number}{floatNumber}{doubleNumber}{decimalNumber}{isTrue}{typeof(int)}");
            Console.ReadLine();
        }
    }
}
