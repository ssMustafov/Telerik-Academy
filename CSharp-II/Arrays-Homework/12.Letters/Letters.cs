using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letters
{
    class Letters
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];

            int count = 65;
            
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)count;
                count++;
            }

            string word = Console.ReadLine();

            Console.WriteLine("The indexes are: ");
            for (int k = 0; k < word.Length; k++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (letters[j] == word[k])
                    {
                        Console.Write("{0} ", j);
                    }        
                }
            }
            Console.WriteLine();
        }
    }
}