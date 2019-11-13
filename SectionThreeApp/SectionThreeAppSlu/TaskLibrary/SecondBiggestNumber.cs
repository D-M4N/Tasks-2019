using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SectionThreeLibrary
{
    public class SecondBiggestNumber
    {

        public void SecondBiggest()
        {

            
            int[] numberList = new int[] { 2, 1, 5, 4, 9, 3, };
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
            Console.WriteLine();


        }
    }
}

