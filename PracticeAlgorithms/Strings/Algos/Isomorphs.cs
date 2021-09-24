using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class Isomorphs
    {
        public bool AreIsomorphic(string a, string b)
        {
            //lenght of two strings must be same to be considered isomorphic
            if(a.Length != b.Length)
            {
                return false;
            }

			//use dictionary to store mappings of a chars to b chars.
			var map = new Dictionary<char, char>();

			for (int i = 0; i < a.Length; i++)
			{
				char c1 = a[i];
				char c2 = b[i];

				//if c1 has been encountered before
				if (map.ContainsKey(c1))
				{
					//return false if first occurrence of c1 is mapped to a different character
					if (map[c1] != c2)
					{
						return false;
					}
				}

				//if c1 is encountered for the first time, 
				else
				{
					//add c1 to dictionary and c2 as its value & continue looping
					map.Add(c1, c2);
				}
			}

			return true;
		}
    }
}
