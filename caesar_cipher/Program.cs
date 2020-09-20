using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caesar_cipher
{
    class Program
    {
        public static char chipher(char ch,int key)
        {
            if(!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Enc(string input,int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output = output + chipher(ch, key);
            return output;

        }
        static void Main(string[] args)
        {
            again:
                Console.WriteLine("Type a String to Encrypt:");
                string userString = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter the key: ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Encrypted data");
                string cipherText = Enc(userString, key);
                Console.WriteLine(cipherText);
                Console.WriteLine("Do you want to encode other text: ");
                Console.WriteLine();
                mistake:
                    Console.WriteLine("press 1 for YES and 2 for NO: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (k == 1)
                        goto again;
                    else if (k == 2)
                        Environment.Exit(0);
                    else
                    {
                        Console.WriteLine("you have entered a wrong choice!!!");
                        goto mistake;
                    }

            Console.ReadKey();
        }
    }
}
