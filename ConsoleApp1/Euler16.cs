using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Euler16
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 2 };
            for(int i =0; i < 999;i++)
            {
                bool holdOneForNext = false;
                for (int x = numbers.Count-1; x >= 0; x--)
                {
                    int extraOne = 0;
                    if (holdOneForNext)
                    {
                        extraOne = 1;
                    }
                    holdOneForNext = false;
                    if(numbers[x] * 2 + extraOne >= 10)
                    {
                        numbers[x] = numbers[x] * 2 + extraOne -10;
                        holdOneForNext = true;
                    }
                    else
                    {
                        numbers[x] = numbers[x] * 2 + extraOne;
                    }
                    if (x == 0 && holdOneForNext)
                    {
                        holdOneForNext = false;
                        numbers.Insert(0, 1);
                    }
                }
            }
            int bigNumber = 0;
            foreach(var number in numbers)
            {
                bigNumber += number;  
            }
            Console.WriteLine(bigNumber);
            Console.WriteLine(numbers.Count);
            
        }
    }
}
