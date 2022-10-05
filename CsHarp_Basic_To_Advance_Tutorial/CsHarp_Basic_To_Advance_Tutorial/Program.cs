using CsHarp_Basic_To_Advance_Tutorial.TypeConversion;
using CsHarp_Basic_To_Advance_Tutorial.ValueOrReferenceTypes;
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

            Console.ReadLine();
        }
    }
}
