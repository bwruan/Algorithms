using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class DigitOnlyString
    {
        public bool CheckStringIsDigitOnly(string word)
        {
            var num = 0;

            //try to parse string into integer
            //if does not work, return false
            if (!int.TryParse(word, out num)){
                return false;
            }
            else
            {
                //otherwise return true
                return true;
            }
        }
    }
}
