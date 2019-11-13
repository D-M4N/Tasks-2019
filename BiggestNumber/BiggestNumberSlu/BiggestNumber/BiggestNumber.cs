using System;

namespace BiggestNumber
{
    class BiggestNumber
    {
        public static void Main()
        {

                Console.WriteLine("THE BIGGEST NUMBER");
                Console.WriteLine();

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




            string tag = "$ 😎 D-M4N 😎 $";
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (tag.Length / 2)) + "}", tag));
            Console.Read();
        }
    }
}
