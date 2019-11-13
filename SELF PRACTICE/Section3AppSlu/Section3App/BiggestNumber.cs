using System;
using WordNumberLibrary;


namespace WordNumberLibrary
{
    class BiggestNumber
    {
        public static void Main()
        {

                Console.WriteLine("THE BIGGEST NUMBER");
                Console.WriteLine();

            int n;

            float biggestNumber; 
            int[] a = new int[50]; /*D-M4N*/

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("TYPE THE NUMBER 10 FOLLOWED BY THEN ENTER KEY ON YOUR KEYBOARD");
            
            string s = Console.ReadLine();

                Console.WriteLine();

            n = Int32.Parse(s);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TYPE YOUR NUMBERS FROM 1 TO 10 IN ANY ORDER, FOLLOWED BY THE ENTER KEY AFTER EACH ONE");
            


            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

                Console.Write("");
                Console.WriteLine();

            biggestNumber = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] > biggestNumber)
                    biggestNumber = a[i];
            }

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("THE BIGGEST NUMBER IS {0}", biggestNumber);
            
                Console.WriteLine();
            
            


            string tag = "$ 😎 D-M4N 😎 $"; 
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (tag.Length / 2)) + "}", tag));
            Console.Read();
        }
    }
}
