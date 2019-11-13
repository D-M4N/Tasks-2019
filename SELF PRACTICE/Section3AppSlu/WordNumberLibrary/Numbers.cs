using System;
using System.Collections.Generic;
using System.Text;


namespace WordNumberLibrary
{
    public class Numbers
    {
        public static void Main()
        {
            int n;

            float large, largeTwo;
            int[] a = new int[50];
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("HOW MANY NUMBERS DO YOU WANT TO DISPLAY ?");
            string s = Console.ReadLine();

            n = Int32.Parse(s);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TYPE EACH OF YOUR NUMBERS, FOLLOWED BY THE ENTER KEY AFTER EACH ONE");


            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

            Console.Write("");
            large = a[0];
            largeTwo = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > large)
                    large = a[i];
                else if (a[i] < largeTwo)
                    largeTwo = a[i];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("THE LARGEST NUMBER IS {0}", large);

            Console.WriteLine("THE SECOND LARGEST NUMBER IS {0}", largeTwo);
        }
    }

}

