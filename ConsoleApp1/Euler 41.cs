using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_41
    {
        public void Run()
        {
            List<Int64> primes = allPrimesBelowX(Convert.ToInt64(1e10));
            Int64 biggestP = 0;
            foreach(var prime in primes)
            {
                if (IsPandigital(prime))
                {
                    biggestP = prime;
                }
            }
        }

        public bool IsPandigital(Int64 n)
        {
            string number = n.ToString();

            for(int i = 0; i < number.Length; i++)
            {
                if(!number.Contains((i + 1).ToString()[0]))
                {
                    return false;
                }
            }
            return true;
        }

        public List<Int64> allPrimesBelowX(Int64 x)
        {
            Int64 number = 1;
            List<Int64> primefactor = new List<Int64>() { 2 };
            Console.WriteLine("starting");
            while (number < x)
            {
                number += 2;
                bool aprime = true;
                double rootValue = Math.Sqrt(number);
                for(int i =2; i < rootValue; i++)
                {
                    if(number % i == 0)
                    {
                        aprime = false;
                        break;
                    }
                }
                //foreach (var prime in primefactor)
                //{
                //    if (number % prime == 0)
                //    {
                //        aprime = false;
                //        break;
                //    }
                //}
                if (aprime)
                {
                    if (IsPandigital(number))
                    {
                        Console.WriteLine(number);
                    }
                    primefactor.Add(number);
                }
            }

            return primefactor;
        }
    }
}
