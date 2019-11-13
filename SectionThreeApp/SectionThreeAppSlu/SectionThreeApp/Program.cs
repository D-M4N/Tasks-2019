using System;
using SectionThreeLibrary;



namespace SectionThreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("THE BIGGEST NUMBER");           
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*SectionThreeLibrary.BiggestNumber A = new BiggestNumber();
            A.Biggest();*/

            var BiggestNumber = new BiggestNumber();
            BiggestNumber.Biggest();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SECOND BIGGEST NUMBER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            /*SectionThreeLibrary.SecondBiggestNumber B = new SecondBiggestNumber();
            B.SecondBiggest();*/

            var SecondBiggestNumber = new SecondBiggestNumber();
            SecondBiggestNumber.SecondBiggest();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CAPITALIZE EACH LETTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

                SectionThreeLibrary.CapitalizeEachLetter C = new CapitalizeEachLetter();
                C.CapitalizeLetters();
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("THE NUMBER OF LETTERS IN A SENTENCE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

                SectionThreeLibrary.NumberLetters D = new NumberLetters();
                D.NumberOfLetter();


            string tag = "$ 😎 D-M4N 😎 $";
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (tag.Length / 2)) + "}", tag));
            Console.Read();
        }
    }
}
