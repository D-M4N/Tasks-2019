using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SectionThreeLibrary
{
    public class SecondBiggestNumber
    {

        public static void SecondBiggest()
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


        }
    }
}

