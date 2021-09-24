using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class Substring
    {
        public bool CheckIfSubstring(string a, string b)
        {
            if (!b.Contains(a))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
