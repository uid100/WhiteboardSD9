using System;

namespace CamelCase
{
    public class StringMethods
    {
        // write a method to return a "camel case" string from an input string:
        // "The Cat In The Hat" should return "theCatInTheHat"
        public static string CamelCase(string inputString)
        {
            string result = "";

            bool newWord = false;
            foreach(char c in inputString)
            {
                if (char.IsWhiteSpace(c) || c == '-') newWord = true;
                if( char.IsLetterOrDigit(c) || c == '_')
                {
                    result += newWord ? char.ToUpper(c) : char.ToLower(c);
                    newWord = false;
                }
            }
            return result;
        }
        public static string PascalCase(string inputString)
        {
            string camelCase = CamelCase(inputString);

            string result = "";
            result += char.ToUpper(camelCase[0]);

            for (int i = 1; i < camelCase.Length; i++)
            {
                result += camelCase[i];
            }
            return result;
        }
    }
}
