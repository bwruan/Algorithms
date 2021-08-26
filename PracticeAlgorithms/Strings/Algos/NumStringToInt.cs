using System;

namespace Strings.Algos
{
    public class NumStringToInt
    {
        public void ConvertStringToInt(string numString)
        {
            //current x 10 + newCurrent
            // e.g. string of "123456" - > int of 123456
            //start with 1....how to get 12 (adding will give 3 instead of 12)
            //1 * 10 = 10 + 2 = 12; 12 * 10 = 120 + 3 = 123, etc
            var num = 0;
            var startIndex = 0;

            //check if string is a negative number string or a positive number string with explicit positive sign
            startIndex = (numString[0] == '-' || numString[0] == '+') ? 1 : 0;

            //loop through length of string and convert individually and add on to the end of converted int
            for (int i = startIndex; i < numString.Length; i++)
            {
                switch (numString[i])
                {
                    case '0':
                        num = (num * 10);
                        break;
                    case '1':
                        num = (num * 10) + 1;
                        break;
                    case '2':
                        num = (num * 10) + 2;
                        break;
                    case '3':
                        num = (num * 10) + 3;
                        break;
                    case '4':
                        num = (num * 10) + 4;
                        break;
                    case '5':
                        num = (num * 10) + 5;
                        break;
                    case '6':
                        num = (num * 10) + 6;
                        break;
                    case '7':
                        num = (num * 10) + 7;
                        break;
                    case '8':
                        num = (num * 10) + 8;
                        break;
                    case '9':
                        num = (num * 10) + 9;
                        break;
                }
            }

            //check if startIndex was 1 and first char in initial index was negative
            //times -1 if so
            num = (startIndex == 1 && numString[0] == '-') ? num * -1 : num;
            Console.WriteLine(num);

            //another way on internet
            //var num = 0;
            //for (int i = 0; i < numString.Length; i++)
            //{
            //    48 is ASCII value for 0...
            //    num = num * 10 + (numString[i] - 48);
            //}

            //Console.Write(num);
        }
    }
}
