using System;

namespace BinaryFunctions
{
    public class BinaryString
    {
        public static string intToBinary(int num)
        {
            int binaryValue = 0;
            int digit = 1;
            for (int Y = num; Y > 0; Y /= 2)
            {
                binaryValue = binaryValue + (Y % 2) * digit;
                digit *= 10;
            }
            return binaryValue.ToString();
        }
    }
}
