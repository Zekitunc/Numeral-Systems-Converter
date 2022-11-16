using System;
using System.Collections.Generic;
using System.Text;

namespace Project1_Computational_109843
{
    class EnginePointeDecimalConverter
    {
        public static string ConvertPointDecimalToBinary(string number)
        {
            List<string> numbers = new List<string>();
            string Binary_str = "";
            string AfterPoint = "";
            string BeforePoint = "";
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != "." && numbers[i] != ",")
                    BeforePoint += Convert.ToString(numbers[i]);
                else if (numbers[i] == "." || numbers[i] == ",")
                {
                    i++;
                    for (; i < numbers.Count; i++)
                    {
                        AfterPoint += Convert.ToString(numbers[i]);
                    }
                    break;
                }
            }
            string numbersAfter = "";
            double AfterP = Convert.ToDouble(AfterPoint);
            double x = AfterP / Math.Pow(10, AfterPoint.Length);
            for (int i = 0; i < numbers.Count + 4; i++)
            {
                x = x * 2;
                double Check = x / 1;
                if (Check < 1)
                    numbersAfter += "0";
                else
                {
                    numbersAfter += "1";
                    x = x - 1;
                }

                AfterP = x;
                double divide = x % 1;
                if (divide == 0)
                    break;
            }
            int divided = Convert.ToInt32(BeforePoint);
            int forBinary = Convert.ToInt32(BeforePoint);
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
                Binary_str += Convert.ToString(Reverse[i]);
            }
            return Binary_str + "." + numbersAfter;
        } //WORKİNG 
        public static string ConvertPointDecimalToOctal(string number)
        {
            List<string> numbers = new List<string>(); //521.421
            string Octal_str = "";
            string AfterPoint = "";
            string BeforePoint = "";
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != "." && numbers[i] != ",")
                    BeforePoint += Convert.ToString(numbers[i]); //"521"
                if (numbers[i] == "." || numbers[i] == ",")
                {
                    i++;
                    for (; i < numbers.Count; i++)
                    {
                        AfterPoint += Convert.ToString(numbers[i]); //"421"
                    }
                    break;
                }
            }
            string numbersAfter = "";
            double AfterP = Convert.ToDouble(AfterPoint);
            double x = AfterP / Math.Pow(10, AfterPoint.Length);
            double Check;
            for (int i = 0; i < numbers.Count + 4; i++)
            {
                x = x * 8;
                Check = x / 1;
                if (Check < 1)
                    numbersAfter += "0";
                else
                {
                    numbersAfter += Convert.ToString(Check).Substring(0, 1);
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 1));
                }
                AfterP = x;
                double divide = x % 1;
                if (divide == 0)
                    break;
            }
            int divided = Convert.ToInt32(BeforePoint);
            int forBinary = Convert.ToInt32(BeforePoint);
            List<int> Reverse = new List<int>();
            while (true)
            {
                forBinary = divided;
                divided = forBinary / 8;
                int remainder = forBinary % 8;
                Reverse.Add(remainder);
                if (divided == 0)
                    break;
            }
            for (int i = Reverse.Count - 1; i >= 0; i--)
            {
                Octal_str += Convert.ToString(Reverse[i]);
            }
            return Octal_str + "." + numbersAfter;
        } //WORKİNG
        public static string ConvertPointDecimalToHexal(string number)
        {
            List<string> numbers = new List<string>(); //521.421
            string Hexal_str;
            string AfterPoint = "";
            string BeforePoint = "";
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != "." && numbers[i] != ",")
                    BeforePoint += Convert.ToString(numbers[i]); //"521"
                else if (numbers[i] == "." || numbers[i] == ",")
                {
                    i++;
                    for (; i < numbers.Count; i++)
                    {
                        AfterPoint += Convert.ToString(numbers[i]); //"421"
                    }
                    break;
                }
            }
            string numbersAfter = "";
            double AfterP = Convert.ToDouble(AfterPoint);
            double x = AfterP / Math.Pow(10, AfterPoint.Length);
            double Check;
            for (int i = 0; i < numbers.Count + 4; i++)
            {
                x = x * 16;
                Check = x / 1;
                if (Check < 1)
                    numbersAfter += "0";
                else if (Check < 10)
                {
                    numbersAfter += Convert.ToString(Check).Substring(0, 1);
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 1));
                }
                else if (Convert.ToInt32(Convert.ToString(Check).Substring(0, 2)) == 10)
                {
                    numbersAfter += "A";
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 2));
                }
                else if (Convert.ToInt32(Convert.ToString(Check).Substring(0, 2)) == 11)
                {
                    numbersAfter += "B";
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 2));
                }
                else if (Convert.ToInt32(Convert.ToString(Check).Substring(0, 2)) == 12)
                {
                    numbersAfter += "C";
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 2));
                }
                else if (Convert.ToInt32(Convert.ToString(Check).Substring(0, 2)) == 13)
                {
                    numbersAfter += "D";
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 2));
                }
                else if (Convert.ToInt32(Convert.ToString(Check).Substring(0, 2)) == 14)
                {
                    numbersAfter += "E";
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 2));
                }
                else if (Convert.ToInt32(Convert.ToString(Check).Substring(0, 2)) == 15)
                {
                    numbersAfter += "F";
                    x = x - Convert.ToInt32(Convert.ToString(Check).Substring(0, 2));
                }
                AfterP = x;
                double divide = x % 1;
                if (divide == 0)
                    break;
            }
            Hexal_str = "";
            int divided = Convert.ToInt32(BeforePoint);
            int foroctal = Convert.ToInt32(BeforePoint);
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
                Hexal_str += Convert.ToString(Reverse[i]);
            }
            return Hexal_str + "." + numbersAfter;
        } //WORKİNG
        public static string ConvertPointOctalToDecimal(string number)
        {
            List<string> numbers = new List<string>();
            string AfterPoint = "";
            string BeforePoint = "";
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != ".")
                    BeforePoint += Convert.ToString(numbers[i]);
                if (numbers[i] == ".")
                {
                    i++;
                    for (; i < numbers.Count; i++)
                    {
                        AfterPoint += Convert.ToString(numbers[i]);
                    }
                    break;
                }
            }
            List<string> Beforenumbers = new List<string>();
            for (int i = 0; i < BeforePoint.Length; i++)
            {
                Beforenumbers.Add(Convert.ToString(BeforePoint[i]));
            }
            double sum1 = 0;
            int s = 0;
            const int numberBase = 8;
            for (int a = Beforenumbers.Count - 1; a >= 0; a--)
            {
                sum1 += Convert.ToInt32(Beforenumbers[s]) * Math.Pow(numberBase, a);
                s++;
            }  //we get Sum1
            List<string> Afternumbers = new List<string>();
            for (int i = 0; i < AfterPoint.Length; i++)
            {
                Afternumbers.Add(Convert.ToString(AfterPoint[i]));
            }
            double sum2 = 0;
            int d = Afternumbers.Count - 1;
            for (int a = 0 - Afternumbers.Count; a != 0; a++)
            {
                sum2 += Convert.ToInt32(Afternumbers[d]) * Math.Pow(8, a);
                d--;
            }  //we get Sum2
            sum2 = sum1 + sum2;
            return Convert.ToString(sum2);
        }//WORKİNG
        public static string ConvertPointHexalToDecimal(string number)
        {
            List<string> numbers = new List<string>();
            string AfterPoint = "";
            string BeforePoint = "";
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(Convert.ToString(number[i]));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != ".")
                    BeforePoint += Convert.ToString(numbers[i]);
                if (numbers[i] == ".")
                {
                    i++;
                    for (; i < numbers.Count; i++)
                    {
                        AfterPoint += Convert.ToString(numbers[i]);
                    }
                    break;
                }
            }
            List<string> Beforenumbers = new List<string>();
            for (int i = 0; i < BeforePoint.Length; i++)
            {
                Beforenumbers.Add(Convert.ToString(BeforePoint[i]));
            }
            double sum1 = 0;
            int s = 0;
            for (int a = Beforenumbers.Count - 1; a >= 0; a--)
            {
                sum1 += Convert.ToInt32(Beforenumbers[s]) * Math.Pow(16, a);
                s++;
            }  //we get Sum1
            List<string> Afternumbers = new List<string>();
            for (int i = 0; i < AfterPoint.Length; i++)
            {
                Afternumbers.Add(Convert.ToString(AfterPoint[i]));
            }
            double sum2 = 0;
            int d = Afternumbers.Count - 1;
            for (int a = 0 - Afternumbers.Count; a != 0; a++)
            {
                sum2 += Convert.ToInt32(Afternumbers[d]) * Math.Pow(16, a);
                d--;
            }  //we get Sum2
            sum2 = sum1 + sum2;
            return Convert.ToString(sum2);
        }//WORKİNG
    }
}
