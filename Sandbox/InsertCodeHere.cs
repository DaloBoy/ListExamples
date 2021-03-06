﻿using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // Case 1
            //Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // Case 2
            //Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);
 
            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // Case 3
            // Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // Case 4
            // Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);



            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // Case 5: Make some code that prints out 
            // all the elements in the list

            foreach(int l in aListOfInt)
            {
                Console.WriteLine($"værdien er : {l}");
            }


            // Case 6: Make some code that finds the 
            // sum of the elements in the list, and prints the result

            int code = 0;
            foreach (int list in aListOfInt)
            {
                code = code + list;
            }
            Console.WriteLine($"summen af tallene er : {code}");

            // Case 7: Make some code that finds the 
            // average of the elements in the list, and prints the result
            // Tip: Think about how average is defined; then
            // you might reuse something from Case 6
            double codes = 0;
            double count = 0;
            foreach (double lis in aListOfInt)
            {
                codes = codes + lis;
                codes++;
            }
            Console.WriteLine($"gennemsnittet er : {codes/count}");

            // [DIFFICULT]
            // Case 8: Make some code that finds the
            // smallest element in the list, and prints the result

            int lowestNumber = 1000;
            foreach (int lin in aListOfInt)
            {
                if (lin <= lowestNumber)
                {
                    lowestNumber = lin;
                }
            }
            Console.WriteLine($"Det laveste tal er : {lowestNumber}");

            // Tip: Think in detail about how you would do this manually








            // The LAST line of code should be ABOVE this line
        }
    }
}
