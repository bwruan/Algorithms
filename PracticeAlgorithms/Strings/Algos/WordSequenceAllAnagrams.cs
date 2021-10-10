using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class WordSequenceAllAnagrams
    {
        public void PrintAllAnagrams(string[] a)
        {
            var map = new Dictionary<string, List<string>>();

            for (int i = 0; i < a.Length; i++)
            {
                string word = a[i];
                char[] c = word.ToCharArray();
                Array.Sort(c);
                var newWord = new string(c);

                if (map.ContainsKey(newWord))
                {
                    map[newWord].Add(word);
                }
                else
                {
                    var words = new List<string>();
                    words.Add(word);
                    map.Add(newWord, words);
                }
            }

            var value = new List<string>();
            foreach(var entry in map)
            {
                value.Add(entry.Key);
            }

            int k = 0;
            foreach(var entry in map)
            {
                var values = map[value[k++]];
                if(values.Count > 1)
                {
                    Console.Write("[");
                    var len = 1;
                    foreach(var s in values)
                    {
                        Console.Write(s);
                        if(len++ < values.Count)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write("]");
                }
            }
        }
    }
}
