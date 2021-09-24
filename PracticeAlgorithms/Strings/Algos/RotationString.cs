using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class RotationString
    {
        public bool IsRotatedTwoPlaces(string a, string b)
        {
            //check length
            if (a.Length != b.Length)
            {
                return false;
            }

            if (a.Length < 2)
            {
                return a.Equals(b);
            }

            string clock_rot = "";
            string anticlock_rot = "";
            int len = b.Length;

            // Initialize string as anti-clockwise rotation
            anticlock_rot
                = anticlock_rot + b.Substring(len - 2, len - (len - 2)) + b.Substring(0, len - 2);

            // Initialize string as clock wise rotation
            clock_rot = clock_rot + b.Substring(2) + b.Substring(0, 2);

            // check if any of them is equal to string1
            return (a.Equals(clock_rot) || a.Equals(anticlock_rot));
        }
    }
}
