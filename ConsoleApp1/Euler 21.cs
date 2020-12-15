using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Euler_21
    {
        public void Run()
        {
            List<int> amicableNumbers = new List<int>();

            for(int x = 1; x< 10001; x++)
            {
                if (!amicableNumbers.Contains(x))
                {
                    var other = IsNumberAmicableNumber(x);
                    if (other != 0 && x != other)
                    {
                        amicableNumbers.AddRange(new List<int>{ x, other});
                    }
                }
            }
            int total = 0;
            foreach(int n in amicableNumbers)
            {
                total += n;
            }
            Console.WriteLine(total);
        }

        public List<int> GetWholeDivisors(int number)
        {
            var divs = new List<int>();
            for(int i = 1; i< (number/2)+1; i++)
            {
                if(number % i == 0)
                {
                    divs.Add(i);
                }
            }
            return divs;
        }

        /// <summary>
        /// Will return the pair amicableNumber if the numer is Amicable if not then it will return 0;
        /// </summary>
        /// <param name="number"></param>
        /// <returns>number above 0 if number is amicable if not then it returns zero</returns>
        public int IsNumberAmicableNumber(int number)
        {
            int otherNumber = 0;
            foreach(int n in GetWholeDivisors(number))
            {
                otherNumber += n;
            }
            int sumOfDivOfOtherNumber = 0;
            foreach(int n in GetWholeDivisors(otherNumber))
            {
                sumOfDivOfOtherNumber += n;
            }
            if(sumOfDivOfOtherNumber == number)
            {
                return otherNumber;
            }
            else
            {
                return 0;
            }
        }
    }
}
