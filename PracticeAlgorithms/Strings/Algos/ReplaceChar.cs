using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class ReplaceChar
    {
        //for this method, replace blank with %20
        //this is sparta -> 2 spaces + 2 spaces/space to fit %20 aka add 4 spaces total (space count * 2)
        //old length: 14; new length: 18 14 + 4 or eq would be length + 2* spacecount
        public void ReplaceBlankWithPercTwenty(string input)
        {
            //convert string into char[]
            var inputArr = input.ToCharArray();

            //initialize a variable to count blanks
            var spaceCount = 0;

            //loop through string and count the blanks
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceCount += 1;
                }
            }

            //when replacing, new length will happen...as you are adding %20, you will need 2 additional spaces per blank to equal to 3 spaces (blank is a space itself)
            var newLength = input.Length + (2 * spaceCount);

            //new array to hold char of our new string
            var newInputArr = new char[newLength];

            //loop backwards through the string
            for (int i = inputArr.Length - 1; i >= 0; i--)
            {
                //if encounter a blank replace with %20
                if(inputArr[i] == ' ')
                {
                    newInputArr[newLength - 1] = '0';
                    newInputArr[newLength - 2] = '2';
                    newInputArr[newLength - 3] = '%';

                    newLength = newLength - 3;
                }
                else //otherwise, copy the character into the new array
                {
                    newInputArr[newLength - 1] = inputArr[i];
                    newLength = newLength - 1;
                }

                //print as string in console
                Console.WriteLine(newInputArr.ToString());
            }
        }
    }
}
