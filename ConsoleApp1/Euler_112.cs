using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_112
    {
        public void Run()
        {
            int totalNumbers = 1;
            int currentNumber = 101;
            int totalBouncy = 0;
            int totalNotBouncy = 0;
            bool stop = false;
            while (!stop)
            {
                if (IsBouncy(currentNumber))
                {
                    totalBouncy++;
                }
                else
                {
                    totalNotBouncy++;
                }
                totalNumbers++;
                currentNumber++;// last step;
                if(currentNumber == 539)
                {
                    Console.WriteLine(Convert.ToDouble(totalBouncy) / Convert.ToDouble(currentNumber-1));
                    Console.WriteLine(currentNumber - 1);
                }
                if (Convert.ToDouble(totalBouncy) / Convert.ToDouble(currentNumber - 1) >= 0.99)
                {
                    Console.WriteLine(Convert.ToDouble(totalBouncy) / Convert.ToDouble(currentNumber - 1));
                    Console.WriteLine(currentNumber-1);
                    stop = true;
                }
            }
            Console.WriteLine("bouncy: " + totalBouncy);
            Console.WriteLine("n-bouncy: " + totalNotBouncy);
            Console.WriteLine("total: " + totalNumbers);
            Console.WriteLine("nextnumber: " + currentNumber);
        }

        private bool IsBouncy(int number)
        {
            string numberWritten = number.ToString();
            int prevNumber = int.Parse(numberWritten[0].ToString());
            bool first = false;
            bool positiveChange = false;
            bool negativeChange = false;
            foreach (char c in number.ToString())
            {
                if (!first)
                {
                    first = true;
                    //ignore
                }
                else
                {
                    if (c.CharToNumber() > prevNumber)
                    {
                        positiveChange = true;
                    }
                    else if (c.CharToNumber() < prevNumber)
                    {
                        negativeChange = true;
                    }
                    else if (c.CharToNumber() == prevNumber)
                    {
                        //ignore
                    }
                    prevNumber = c.CharToNumber();
                }
            }
            if (positiveChange && negativeChange)
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
