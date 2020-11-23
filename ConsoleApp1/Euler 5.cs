using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    /*
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     */
    public class Euler_5
    {
        public void Run()
        {
            bool found = false;
            Int64 curnumber = 2520;
            while (!found)
            {
                curnumber += 20;
                for(int i = 1; i <= 20; i++)
                {
                    if(curnumber % i == 0)
                    {
                        if(i == 20)
                        {
                            found = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
            Console.WriteLine(curnumber);
        }
    }
}
