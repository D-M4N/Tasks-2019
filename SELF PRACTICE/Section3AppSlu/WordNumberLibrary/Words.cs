using System;
using System.Collections.Generic;
using System.Text;

namespace WordNumberLibrary
{
    class Words
    {
        public static void Main()
        {
            string Sampleinput = "so how are you doing";
            string Output = "";
            string[] inputWords = Sampleinput.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in inputWords)
            {
                char[] a = word.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                Output += new string(a) + " ";
            }
            Console.WriteLine(Output);
        }
    }
}
