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
            //var dataType = new DataType();
            //Console.WriteLine($"String: {dataType.print}\n{dataType.number}{dataType.floatNumber}{dataType.doubleNumber}{dataType.decimalNumber}{dataType.isTrue}{typeof(int)}");

            #endregion

            #region Value Or Reference Type
            //var obj = new ValueOrReferenceType();

            //var valueType = obj.a = obj.b;
            //var referenceType = obj.fName = obj.LName;
            //Console.WriteLine($"\n valueType: {valueType}\n ReferenceType: {referenceType}");
            //Console.WriteLine($"\n valueType: {obj.a}-{obj.b}\n ReferenceType: {obj.fName}-{obj.LName}");
            #endregion

            #region Type Conversion 
            ////var obj1 = new typeconversion();
            ////double implicitConversion = obj1.iNumber;
            ////int explicitConversion = (int)obj1.dNumber;

            ////Console.WriteLine($"\n Implicit:{implicitConversion}\n Explicit:{explicitConversion}");
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
