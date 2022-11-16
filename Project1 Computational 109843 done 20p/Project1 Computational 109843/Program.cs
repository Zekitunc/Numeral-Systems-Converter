using System;
using System.Collections.Generic;

namespace Project1_Computational_109843
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if you input normal decimal number directly write");
            Console.WriteLine("if you input Octal decimal number firstly put 0 and directly write");
            Console.WriteLine("if you input Hexal decimal number firstly put 0x and directly write");
            Console.WriteLine("Type a number");
            string İnputStr = Console.ReadLine();
            int Check = 0;
            bool Point = false;
            //Check = 0 int 1 Octal 2 Hexal
            
            for (int i = 0; i < İnputStr.Length; i++)
            {
                if (Convert.ToString(İnputStr[i]) == ".")
                    Point = true;
            }
            if (Convert.ToString(İnputStr[0]) == "0")
            {
                Check = 1;
                if (Convert.ToString(İnputStr[1]) == "x" || Convert.ToString(İnputStr[1]) == "X")
                    Check = 2;
            }
            //normal decimal and not fractions task1 completed
            if (Point==false && Check==0)
            {
                Console.WriteLine("==============");
                Console.WriteLine("In Decimal:  " + İnputStr);
                Console.WriteLine("==============");
                Console.WriteLine("In Bınary:  " + DecimalConverterEngine.ConvertDecimalToBinary(İnputStr));
                Console.WriteLine("==============");
                Console.WriteLine("In Octal:  0" + DecimalConverterEngine.ConvertDecimalToOctal(İnputStr));
                Console.WriteLine("==============");
                Console.WriteLine("In Hex:  0x" + DecimalConverterEngine.ConvertDecimalToHexal(İnputStr));
            }
            //Octal and not fractions task2 completed
            else if (Point == false && Check == 1)
            {
                string newinput = İnputStr.Substring(1, İnputStr.Length - 1);
                string decimalver = DecimalConverterEngine.ConvertOctalToDecimal(newinput);
                Console.WriteLine("==============");
                Console.WriteLine("In Decimal:  " + decimalver);
                Console.WriteLine("==============");
                Console.WriteLine("In Bınary:  " + DecimalConverterEngine.ConvertDecimalToBinary(decimalver));
                Console.WriteLine("==============");
                Console.WriteLine("In Octal:  0" + newinput);
                Console.WriteLine("==============");
                Console.WriteLine("In Hex:  0x" +DecimalConverterEngine.ConvertDecimalToHexal(decimalver));

            }
            //Hexal and not Fractions task3 completed
            else if (Point == false && Check == 2)
            {
                string newinput = İnputStr.Substring(2, İnputStr.Length - 2);
                string decimalver = DecimalConverterEngine.ConvertHexalToDecimal(newinput);
                Console.WriteLine("==============");
                Console.WriteLine("In Decimal:  " + decimalver);
                Console.WriteLine("==============");
                Console.WriteLine("In Bınary:  " + DecimalConverterEngine.ConvertDecimalToBinary(decimalver));
                Console.WriteLine("==============");
                Console.WriteLine("In Octal:  0" + DecimalConverterEngine.ConvertDecimalToOctal(decimalver));
                Console.WriteLine("==============");
                Console.WriteLine("In Hex:  0x" + newinput);
            }
            //fracitons and Normal Decimal task4 completed
            else if (Point == true && Check == 0)
            {
                Console.WriteLine("==============");
                Console.WriteLine("In Decimal:  " + İnputStr);
                Console.WriteLine("==============");
                Console.WriteLine("In Bınary:  " + EnginePointeDecimalConverter.ConvertPointDecimalToBinary(İnputStr));
                Console.WriteLine("==============");
                Console.WriteLine("In Octal:  0" + EnginePointeDecimalConverter.ConvertPointDecimalToOctal(İnputStr));
                Console.WriteLine("==============");
                Console.WriteLine("In Hex:  0x" + EnginePointeDecimalConverter.ConvertPointDecimalToHexal(İnputStr));
            }
            //fracitons and Octal Decimal task5 completed
            else if (Point == true && Check == 1)
            {
                string newinput = İnputStr.Substring(1, İnputStr.Length - 1);
                string decimalver = EnginePointeDecimalConverter.ConvertPointOctalToDecimal(newinput);
                Console.WriteLine("==============");
                Console.WriteLine("In Decimal:  " + decimalver);
                Console.WriteLine("==============");
                Console.WriteLine("In Bınary:  " + EnginePointeDecimalConverter.ConvertPointDecimalToBinary(decimalver));
                Console.WriteLine("==============");
                Console.WriteLine("In Octal:  0" + newinput);
                Console.WriteLine("==============");
                Console.WriteLine("In Hex:  0x" + EnginePointeDecimalConverter.ConvertPointDecimalToHexal(decimalver));
            }
            //fracitons and Hexal Decimal task6 completed
            else if (Point == true && Check == 2)
            {
                string newinput = İnputStr.Substring(2, İnputStr.Length - 2);
                string decimalver = EnginePointeDecimalConverter.ConvertPointHexalToDecimal(newinput);
                Console.WriteLine("==============");
                Console.WriteLine("In Decimal:  " + decimalver);
                Console.WriteLine("==============");
                Console.WriteLine("In Bınary:  " + EnginePointeDecimalConverter.ConvertPointDecimalToBinary(decimalver));
                Console.WriteLine("==============");
                Console.WriteLine("In Octal:  0" + EnginePointeDecimalConverter.ConvertPointDecimalToOctal(decimalver));
                Console.WriteLine("==============");
                Console.WriteLine("In Hex:  0x" + newinput);
            }
        }
    }
}
