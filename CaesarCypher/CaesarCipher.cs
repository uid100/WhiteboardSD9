using System;

namespace SimpleCrypto
{
    public class CaesarCipher
    {
        static string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static string ring(int key)
        {
            int L = alpha.Length;
            key %= L;
            string cipher = "";
            for(int i=0; i<L; i++)
            {
                int offset = i + key;
                if (key > 0)
                    cipher += alpha[offset < L ? offset : offset - L];
                else
                    cipher += alpha[offset < 0 ? offset + L : offset];
            }
            return cipher;
        }

        public static string CharShift(string message, int key)
        {
            string code = "";
            string cipher = ring(key);

            foreach(char letter in message.ToUpper())
            {
                code += cipher.Contains(letter) ? cipher[alpha.IndexOf(letter)] : letter;
            }

            return code;
        }

        public static string Shift(string inputString, int key)
        {
            string result = "";

            foreach (var c in inputString.ToUpper())
            {
                int n = ((int)(c - 'A') + 26) % 26;
                result += (char)(c + n);
            }

            return result;
        }
    }
}
