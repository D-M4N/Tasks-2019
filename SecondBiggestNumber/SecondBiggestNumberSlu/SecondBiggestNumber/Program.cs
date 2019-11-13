using System;

namespace SecondBiggestNumber
{
    class Program
    {
        public static void Main()
        {

                Console.WriteLine("THE SECOND BIGGEST NUMBER");
                Console.WriteLine();

                int[] numberList = new int[] { 2, 1, 7, 4, 9, 5, };
                int biggest = int.MinValue;
                int secondBiggest = int.MinValue;

            foreach (int number in numberList)
            {
                if (number > biggest)
                {
                    secondBiggest = biggest;
                    biggest = number;
                }
                else if (number > secondBiggest)
                    secondBiggest = number;
            }

                Console.WriteLine(secondBiggest);




                string tag = "$ 😎 D-M4N 😎 $";
                Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (tag.Length / 2)) + "}", tag));
                Console.Read();
        }
    }
}