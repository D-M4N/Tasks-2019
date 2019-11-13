using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace SectionThreeLibrary
{
    public class BiggestNumber
    {
        public static void Biggest()
        {

            int number;

            float biggestNumber;
            int[] a = new int[50]; /*D-M4N*/

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("HOW MANY NUMBERS YOU WANT IN YOUR LIST?");

            string big = Console.ReadLine();

            Console.WriteLine();

            number = Int32.Parse(big);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TYPE YOUR NUMBERS IN ANY ORDER, FOLLOWED BY THE ENTER KEY AFTER EACH ONE.");



            for (int i = 0; i < number; i++)
            {
                string biggest = Console.ReadLine();
                a[i] = Int32.Parse(biggest);
            }

            Console.Write("");
            Console.WriteLine();

            biggestNumber = a[0];

            for (int i = 1; i < number; i++)
            {
                if (a[i] > biggestNumber)
                    biggestNumber = a[i];
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("THE BIGGEST NUMBER IS {0}", biggestNumber);

            Console.WriteLine();
    
        }
    }
}
