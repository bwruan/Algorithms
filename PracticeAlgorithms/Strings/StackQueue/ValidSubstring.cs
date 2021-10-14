using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.StackQueue
{
    public class ValidSubstring
    {
        public int LongestLengthOfValidSubstring(string a)
        {
            //create stacj=k and push -1 as initial index
            var index = new Stack<int>();
            index.Push(-1);

            var result = 0;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(' || a[i] == '{' || a[i] == '{')
                {
                    index.Push(i);
                }
                else
                {
                    if(index.Count == 0)
                    {
                        index.Push(i);
                    }
                    else
                    {
                        index.Pop();
                        result = Math.Max(result, i - index.Peek());
                    }
                }
            }

            return result;
        }
    }
}
