using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_14
    {
        public void Run()
        {
            Int64 highestCollatz = 0;
            for(int i =1; i <= 1000000; i++)
            {
                Int64 curnumber = i;
                int currAmountOfCollatz = 1;
                while(curnumber != 1)
                {
                    if(curnumber % 2 == 0)
                    {
                        curnumber = evenCollatz(curnumber);
                    }
                    else
                    {
                        curnumber = OddCollatz(curnumber);
                    }
                    currAmountOfCollatz++;
                }
                if(currAmountOfCollatz > highestCollatz)
                {
                    highestCollatz = currAmountOfCollatz;
                    Console.WriteLine(highestCollatz);
                    Console.WriteLine(i);
                }
            }
        }

        public Int64 evenCollatz(Int64 number)
        {
            return number / 2;
        }

        public Int64 OddCollatz(Int64 number)
        {
            return ((3 * number) + 1);
        }
    }
}
