using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_10
    {
        public void Run()
        {
            int number = 1;
            List<int> primefactor = new List<int>();
            Console.WriteLine("starting");
            while (number < 2000000)
            {
                number += 2;
                bool aprime = true;
                foreach (var prime in primefactor)
                {
                    if (number % prime == 0)
                    {
                        aprime = false;
                    }
                }
                if (aprime)
                {
                    primefactor.Add(number);
                }
            }
            Int64 total = 0;
            foreach (var prime in primefactor)
            {
                total += prime;
            }
            Console.WriteLine(total);
        }
    }
}
