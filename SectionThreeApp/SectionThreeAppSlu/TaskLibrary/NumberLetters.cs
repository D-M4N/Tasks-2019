using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SectionThreeLibrary
{
    public class NumberLetters
    {
        public void NumberOfLetter()
        {
            Console.WriteLine("Chuck Norris reports noobs and the noobs automaticly be banned from(Insert online site here) unlike the others");
            Console.WriteLine();

            int[] word = new int[(int)char.MaxValue];

            string  sentence = ("chuck norris reports noobs and the noobs automaticly be banned from (insert online site here) unlike the others");

            foreach (char letter in sentence)/*D-M4N*/

            {
                word[(int)letter]++;
            }

            for (int i = 0; i < (int)char.MaxValue; i++)

            {
                if (word[i] > 0 &&

                    char.IsLetterOrDigit((char)i))
                {
                    
                    Console.WriteLine("\"{0}\" -> {1}", (char)i, word[i]);
                }


            }

            
        }
    }
}
  
