using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SectionThreeLibrary
{
    public class CapitalizeEachLetter
    {
        public static void CapitalizeLetters()
        {
            

            string ChuckJoke = "when chuck norris says he is sorry, its not for what he has done, but for what he is about to do to you.";
            string CapitilizeFirstLetterInEachWord = "";
            string[] Sentence = ChuckJoke.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


            foreach (string Letter in Sentence)/*D-M4N*/
            {
                char[] word = Letter.ToCharArray();
                word[0] = char.ToUpper(word[0]);
                CapitilizeFirstLetterInEachWord += new string(word) + " ";
            }

            Console.WriteLine(CapitilizeFirstLetterInEachWord);
            Console.WriteLine();
            
        }
    }
}


