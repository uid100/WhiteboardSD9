using System;

namespace Alphabetize
{
    public class Sorts
    {
        // write a method to return a string in alphabetical order
        public static string StringSort(string inputString)
        {
            string outputString = "";

            // "cat" should return "act"
            for(char letter='a'; letter<='z'; letter++)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if(inputString[i] == letter)
                    {
                        outputString += letter;
                    }
                    else if (inputString[i] == char.ToUpper(letter))
                    {
                        outputString += char.ToUpper(letter);
                    }
                }
            }

            return outputString;
        }
    }
}
