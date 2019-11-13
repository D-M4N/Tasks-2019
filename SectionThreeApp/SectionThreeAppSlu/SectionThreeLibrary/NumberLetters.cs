using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SectionThreeLibrary
{
    public class NumberLetters
    {
        public static void NumberOfLetters(string[] args)
        {
            Console.WriteLine("Chuck Norris reports noobs and the noobs automaticly be banned from(Insert online site here) unlike the others");
            Console.WriteLine();

            int[] word = new int[(int)char.MaxValue];

            string /*D-M4N*/ sentence = ("Chuck Norris reports noobs and the noobs automaticly be banned from (Insert online site here) unlike the others");

            foreach (char letter in sentence)

            {
                word[(int)letter]++;
            }

            for (int i = 0; i < (int)char.MaxValue; i++)

            {
                if (word[i] > 0 &&

                    char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("THE LETTER: {0}  APPEARS: {1}", (char)i, word[i]);
                }


            }

            
        }
    }
}
  
