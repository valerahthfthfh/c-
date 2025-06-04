using System;
using System.Text;

class Program
{
    static string Encrypt(string text, string key)
    {
        StringBuilder result = new StringBuilder(text);
        int i = 0;
        foreach (char c in result.ToString())
        {
            if (char.IsLower(c))
            {
                int shift = key[i % key.Length] - 'a';
                int newChar = ((c - 'a') + shift) % 26 + 'a';
                result[i] = (char)newChar;
            }
            else if (char.IsUpper(c))
            {
                int shift = key[i % key.Length] - 'a';
                int newChar = ((c - 'A') + shift) % 26 + 'A';
                result[i] = (char)newChar;
            }
            i++;
        }
        return result.ToString();
    }

    static string Decrypt(string str, string key)
    {
        // transform the key: each character turns into a number from 0 to 25
        char[] kChars = key.ToLower().ToCharArray();
        for (int i = 0; i < kChars.Length; i++)
        {
            kChars[i] = (char)(kChars[i] - 'a');
        }

        StringBuilder decryptedKey = new StringBuilder();
        foreach (char c in kChars)
        {
            // Invert the shift to decrypt
            int val = c - 1;
            if (val < 0) val += 26;
            val = 25 - val; // Reverse shift
            decryptedKey.Append((char)(val + 'a'));
        }

        return Encrypt(str, decryptedKey.ToString());
    }

    static void Main()
    {
        Console.WriteLine("add text:");
        string text = Console.ReadLine();

        Console.WriteLine("add key:");
        string key = Console.ReadLine();

        string cipher = Encrypt(text, key);
        Console.WriteLine("encrypted text:");
        Console.WriteLine(cipher);

        Console.WriteLine("decrypted text:");
        Console.WriteLine(Decrypt(cipher, key));
    }
}