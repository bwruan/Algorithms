using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.StackQueue
{
    public class BalancedBrackets
    {
        public bool AreBalancedBrackets(string a)
        {
            //initialize a stack
            var openB = new Stack<char>();

            //iterate through the string
            for(int i = 0; i < a.Length; i++)
            {
                //check if open bracket, if so push into stack
                if(a[i] == '(' || a[i] == '{' || a[i] == '{')
                {
                    openB.Push(a[i]);
                }

                //if is close bracket
                if(a[i] == ')' || a[i] == '}' || a[i] == ']')
                {
                    //return false if stack is empty
                    if(openB.Count == 0)
                    {
                        return false;
                    }

                    //return false if does not pair with bracket at top
                    if(a[i] == ')' && openB.Peek() != '(' || a[i] == '}' && openB.Peek() != '{' || a[i] == ']' && openB.Peek() != '[')
                    {
                        return false;
                    }
                    else
                    {
                        openB.Pop();
                    }
                }
            }

            //check to make sure stack is empty
            //if not means not all brackets was paired
            //string is not balanced
            if(openB.Count != 0)
            {
                return false;
            }

            //stack is empty, all paired up and popped
            return true;
        }
    }
}
