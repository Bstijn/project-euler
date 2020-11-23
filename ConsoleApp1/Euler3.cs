using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Euler3
    {
        public void run()
        {
            Int64 number = 600851475143;
            List<int> primefactor = new List<int>();
            while (number > 1)
            {
                Console.WriteLine(number);
                bool nextprimefound = false;
                int i = 2;
                while (nextprimefound == false)
                {
                    if (number % i == 0)
                    {
                        nextprimefound = true;
                        number /= i;
                        primefactor.Add(i);
                    }
                    else
                    {
                        i++;
                        //ignore
                    }
                }
            }
            foreach (var primes in primefactor)
            {
                Console.WriteLine(primes);
            }
        }
    }
}
