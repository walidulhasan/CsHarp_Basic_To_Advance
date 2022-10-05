using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CsHarp_Basic_To_Advance_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataType
            //string print = "Hello World";
            //int number = 10;
            //float floatNumber = 10.4f;
            //double doubleNumber = 10.40;
            //decimal decimalNumber = 30.45m;
            //bool isTrue = false;
            //public byte thisByte = 2223241242;
            //Console.WriteLine($"String: {print}\n{number}{floatNumber}{doubleNumber}{decimalNumber}{isTrue}{typeof(int)}");

            #endregion

            #region Value Or Reference Type
            //int a = 10;
            //int b = 20;
            //string fName = "Kamal";
            //string LName = "Hossen";
            /*Reference Type is
             1.Class
             2.Interface
             3.Object
             Like This
             */

            /*Value Type is
            Data Type
            */


            //var valueType = a = b;
            //var referenceType = fName = LName;
            //Console.WriteLine($"\n valueType: {valueType}\n ReferenceType: {referenceType}");
            //Console.WriteLine($"\n valueType: {a}-{b}\n ReferenceType: {fName}-{LName}");
            #endregion

            #region Type Conversion
            /*Implicit Conversion smaller to LARGER data type like drive to base Class*/
            /*Explicit Conversion Larger to SMALLER data type Possible data loss*/
            //int iNumber = 1000;
            //double dNumber = 12312.454;
            //double implicitConversion = iNumber;
            //int explicitConversion = (int)dNumber;
            //Console.WriteLine($"\n Implicit:{implicitConversion}\n Explicit:{explicitConversion}");
            #endregion

            #region constants
            //const int constants = 10;
            //int constantsV = 10;
            //constants = 10;
            //constantsV = 10;
            //Console.WriteLine(constants);
            #endregion

            #region Decision Statements
            //int day = 100;
            //if (day>0)
            //{
            //    Console.WriteLine($"Day is {day}");
            //}else if (day < 0)
            //{
            //    Console.WriteLine($"Day is {day}");
            //}
            //else
            //{
            //    Console.WriteLine($"Day is {day}");
            //}

            //switch (day)
            //{
            //    case 10:
            //        Console.WriteLine($"Day is {day}");
            //        break;
            //    case 20:
            //        Console.WriteLine($"Day is {day}");
            //        break;
            //    case 30:
            //        Console.WriteLine($"Day is {day}");
            //        break;
            //    case 40:
            //        Console.WriteLine($"Day is {day}");
            //        break;
            //    default:
            //        Console.WriteLine($"Day is {day}");
            //        break;
            //}

            #endregion

            #region Loops
            /*Three part in For Loop 1.Initial Statement 2.Test Condtion 3.increment Statement*/

            //int value = 10;
            //for (int i = 1; i <= value; i++)
            //{
            //    Console.WriteLine($"Result is {i}");
            //}

            /*Three part in while Loop 1.Initial Statement 2.Test Condtion 3.increment Statement*/

            //int valueV = 1;//Initial Statement
            //while (valueV<10)//Test Condtion
            //{
            //    Console.WriteLine($"Result is {valueV}");
            //    valueV++;//increment Statement
            //}

            /*Three part in do-while Loop 1.Initial Statement 2.increment Statement 3.Test Condtion */

            //int valuVV = 1;//Initial Statement
            //do
            //{
            //    Console.WriteLine($"Result is {valuVV}");
            //    valuVV++;//increment Statement
            //} while (valuVV<10);//Test Condtion

            #endregion

            Console.ReadLine();
        }
    }
}
