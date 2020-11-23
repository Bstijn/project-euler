using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*
     * The sum of the squares of the first ten natural numbers is,
     * The square of the sum of the first ten natural numbers is,
     * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
     * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     */
    public class Euler_6
    {
        public void Run()
        {
            Int64 numberOfAllSquares = 0;
            int idontcarehowthisiscalled = 0;
            Int64 sumOfAllNumbersSquared = 0;
            for(int i = 0; i <= 100; i++)
            {
                numberOfAllSquares += i * i;
                idontcarehowthisiscalled += i;
            }
           sumOfAllNumbersSquared= idontcarehowthisiscalled * idontcarehowthisiscalled;
            Console.WriteLine(sumOfAllNumbersSquared);
            Console.WriteLine(numberOfAllSquares);
            Console.WriteLine((sumOfAllNumbersSquared - numberOfAllSquares).ToString());
        }
    }
}
