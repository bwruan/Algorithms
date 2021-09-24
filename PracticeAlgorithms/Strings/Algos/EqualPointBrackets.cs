using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class EqualPointBrackets
    {
        public int FindIndexOfEqualBrackets(string s)
        {
            int len = s.Length;
            int[] open = new int[len + 1];
            int[] close = new int[len + 1];
            int index = -1;

            open[0] = 0;
            close[len] = 0;
            if (s[0] == '(')
            {
                open[1] = 1;
            }
            if (s[len - 1] == ')')
            {
                close[len - 1] = 1;
            }

            // store the number of opening brackets at each index
            for (int i = 1; i < len; i++)
            {
                if (s[i] == '(')
                {
                    open[i + 1] = open[i] + 1;
                }
                else
                {
                    open[i + 1] = open[i];
                }
            }

            // Store the number of closing brackets at each index
            for (int i = len - 2; i >= 0; i--)
            {
                if (s[i] == ')')
                {
                    close[i] = close[i + 1] + 1;
                }
                else
                {
                    close[i] = close[i + 1];
                }
            }

            // check if there is no opening or closing brackets
            if (open[len] == 0 || close[0] == 0)
            {
                return len;
            }

            // check if there is any index at which both brackets are equal
            for (int i = 0; i <= len; i++)
            {
                if (open[i] == close[i])
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
