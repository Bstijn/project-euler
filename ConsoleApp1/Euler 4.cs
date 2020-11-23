using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    /*
     * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */

    class Euler_4
    {
        //step 1 how to identify palindromic number, pn for short
        //step 2 count down number_1 by one and see if 1 * 2 is pn
        //step 3 count down number_2 by one and see if 1 * 2 is pn.
        public void run()
        {
            Console.WriteLine(method_1());
        }

        private int method_1()
        {
            int biggestNumber = 0;
            for(int i = 999; i>0; i--)
            {
                Console.WriteLine("loop: " + i.ToString());
                for(int j = 999; j > 0; j--){
                    if(IdentifyIfNumberIsPalindromic(i * j))
                    {
                        if(i *j > biggestNumber)
                        {
                            Console.WriteLine(i * j);
                            biggestNumber = i * j;
                        }
                        break;
                    }
                }
            }
            return biggestNumber;
        }

        private bool IdentifyIfNumberIsPalindromic(int number)
        {
            string backwords = "";
            foreach(char c in number.ToString())
            {
                backwords = c + backwords;
            }
            if (backwords == number.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
