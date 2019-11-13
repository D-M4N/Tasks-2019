using System;

namespace NumberLetters
{
    class NumberLetters
    {
        static void Main(string[] args)
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

                        string tag = "$ 😎 D-M4N 😎 $";
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (tag.Length / 2)) + "}", tag));
                        Console.Read();
        }
    }
}


