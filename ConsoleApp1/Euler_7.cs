using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_7
    {
        public void Run()
        {
            bool found = false;
            Int64 amountOfPrimes = 3;
            List<Int64> primes = new List<Int64>();
            primes.AddRange(new List<Int64> { 2,3,5});
            Int64 number = 5;
            while (!found)
            {
                number+=2;
                var isnumberprime = true;
                foreach(var prime in primes)
                {
                    if(number % prime == 0){
                        isnumberprime = false;
                        break;
                    }
                }
                if (isnumberprime)
                {
                    amountOfPrimes++;
                    primes.Add(number);
                    if(amountOfPrimes == 10001)
                    {
                        Console.WriteLine(number);
                        found = true;
                    }
                }
            }
        }
    }
}
