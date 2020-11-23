using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_12
    {
        public void Run()
        {
            Int64 number = 1;
            Int64 nextnumber = 2;
            bool found = false;
            int highestdivisiros = 0;
            while (!found)
            {
                number += nextnumber;
                nextnumber += 1;
                var amountOfDivisors = CalculateAmountOfDivisors(number);
                if(amountOfDivisors > highestdivisiros)
                {
                    highestdivisiros = amountOfDivisors;
                    Console.WriteLine(amountOfDivisors);
                }
                if(amountOfDivisors >= 500)
                {
                    found = true;
                }
            }
            Console.WriteLine(number);
        }

        public int CalculateAmountOfDivisors(Int64 number)
        {
            int nod = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                }
            }
            if (sqrt * sqrt == number)
            {
                nod--;
            }

            return nod;
        }
    }
}
