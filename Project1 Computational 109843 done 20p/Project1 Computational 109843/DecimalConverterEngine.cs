using System;
using System.Collections.Generic;
using System.Text;

namespace Project1_Computational_109843
{
    class DecimalConverterEngine
    {
        public static string ConvertDecimalToOctal(string number)
        {
            string octal_str = "";
            int divided = Convert.ToInt32(number);
            int foroctal = Convert.ToInt32(number);
            List<int> Reverse = new List<int>();
            int clock = number.Length + 1;
            while (true)
            {
                foroctal = divided;
                divided = foroctal / 8;
                int remainder = foroctal % 8;
                Reverse.Add(remainder);
                foroctal = divided;
                if (divided == 0)
                    break;
            }
            for (int i = Reverse.Count - 1; i >= 0; i--)
            {
                octal_str += Reverse[i];
            }
            return octal_str;
        } //WORKING 
        public static string ConvertDecimalToBinary(string number)
        {
            string Binary_str = "";
            int divided = Convert.ToInt32(number);
            int forBinary = Convert.ToInt32(number);
            List<int> Reverse = new List<int>();

            while (true)
            {
                forBinary = divided;
                divided = forBinary / 2;
                int remainder = forBinary % 2;
                Reverse.Add(remainder);
                if (divided == 0)
                    break;
            }
            for (int i = Reverse.Count - 1; i >= 0; i--)
            {
                Binary_str += Reverse[i];
            }
            return Binary_str;
        } //WORKİNG 
        public static string ConvertDecimalToHexal(string number)
        {
            string Hexal_str = "";
            int divided = Convert.ToInt32(number);
            int foroctal = Convert.ToInt32(number);
            List<string> Reverse = new List<string>();
            while (true)
            {
                foroctal = divided;
                divided = foroctal / 16;
                int remainder = foroctal % 16;
                string ExRemainder = "";
                if (remainder < 10)
                    Reverse.Add(Convert.ToString(remainder));
                else if (remainder >= 10)
                {
                    if (remainder == 10)
                        ExRemainder = "A";
                    if (remainder == 11)
                        ExRemainder = "B";
                    if (remainder == 12)
                        ExRemainder = "C";
                    if (remainder == 13)
                        ExRemainder = "D";
                    if (remainder == 14)
                        ExRemainder = "E";
                    if (remainder == 15)
                        ExRemainder = "F";
                    Reverse.Add(ExRemainder);
                }
                foroctal = divided;
                if (divided == 0)
                    break;
            }
            for (int i = Reverse.Count - 1; i >= 0; i--)
            {
                Hexal_str += Reverse[i];
            }
            return Hexal_str;
        } //WORKING 
        public static string ConvertOctalToDecimal(string number)
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            double sum = 0;
            int s = 0;
            for (int a = numbers.Count - 1; a >= 0; a--)
            {
                sum += Convert.ToInt32(numbers[s]) * Math.Pow(8, a);
                s++;
            }
            string DecimalStr = Convert.ToString(sum);
            return DecimalStr;
        } //WORKING
        public static string ConvertHexalToDecimal(string number)
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            double sum = 0;
            int s = 0;
            for (int a = numbers.Count - 1; a >= 0; a--)
            {
                if (numbers[s] == "A")
                    sum += 10 * Math.Pow(16, a);
                else if (numbers[s] == "B")
                    sum += 11 * Math.Pow(16, a);
                else if (numbers[s] == "C")
                    sum += 12 * Math.Pow(16, a);
                else if (numbers[s] == "D")
                    sum += 13 * Math.Pow(16, a);
                else if (numbers[s] == "E")
                    sum += 14 * Math.Pow(16, a);
                else if (numbers[s] == "F")
                    sum += 15 * Math.Pow(16, a);
                else
                    sum += Convert.ToInt32(numbers[s]) * Math.Pow(16, a);
                s++;
            }
            string DecimalStr = Convert.ToString(sum);
            return DecimalStr;
        } //WORKİNG
    }
}
