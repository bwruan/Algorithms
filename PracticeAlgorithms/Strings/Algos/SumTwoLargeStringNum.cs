using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class SumTwoLargeStringNum
    {
        public string Sum(string a, string b)
        {
            // ensure length of second string is larger
            if (a.Length > b.Length)
            {
                string temp = a;
                a = b;
                b = temp;
            }

            // Take an empty string for storing result
            string str = "";

            // Calculate length of both string
            int n1 = a.Length;
            int n2 = b.Length;
            int diff = n2 - n1;

            // Initially take carry zero
            int carry = 0;

            // Traverse from end of both strings
            for (int i = n1 - 1; i >= 0; i--)
            {
                //compute sum of current digits and carry
                int sum = ((int)(a[i] - '0') + (int)(b[i + diff] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining digits of b[]
            for (int i = n2 - n1 - 1; i >= 0; i--)
            {
                int sum = ((int)(b[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining carry
            if (carry > 0)
            {
                str += (char)(carry + '0');
            }

            // reverse resultant string
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            return new string(ch2);
        }
    }
}
