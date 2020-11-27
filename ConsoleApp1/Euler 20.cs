using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Euler_20
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 1, 0, 0 };
            for (int x = 99; x > 0; x--)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] *= x;
                }

                for(int i = numbers.Count -1; i >= 0; i--)
                {
                    int tempNumber = numbers[i];
                    if(tempNumber > 9 && tempNumber < 100)
                    {
                        if(i == 0)
                        {
                            numbers[i] = GiveSingle(tempNumber);
                            numbers.Insert(0, GiveDecade(tempNumber));
                        }
                        else
                        {
                            numbers[i] = GiveSingle(tempNumber);
                            numbers[i - 1] += GiveDecade(tempNumber);
                        }
                    }
                    else if(tempNumber > 99 && tempNumber < 1000)
                    {
                        if(i == 1)
                        {
                            numbers[i - 1] += GiveCentury(tempNumber ) * 10; 
                            numbers[i - 1] += GiveDecade(tempNumber);
                            numbers[i] = GiveSingle(tempNumber);
                            
                        }
                        else if(i == 0)
                        {
                            numbers[i] = GiveSingle(tempNumber);
                            numbers.Insert(0, GiveDecade(tempNumber));
                            numbers.Insert(0, GiveCentury(tempNumber));
                            
                        }
                        else
                        {
                            numbers[i - 1] += GiveCentury(tempNumber) * 10;
                            numbers[i - 1] += GiveDecade(tempNumber);
                            numbers[i] = GiveSingle(tempNumber);
                        }
                        
                    }
                    else if(tempNumber < 10)
                    {
                        //ignore
                    }
                    else
                    {
                        throw new Exception("Something went wrong the number is above 100 or below zero");
                    }
                }
            }
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }

            Console.WriteLine(total);
        }

        public int GiveSingle(int number)
        {
            if(number >99){
                return int.Parse("" + number.ToString()[2]);
            }
            else
            {
                return int.Parse("" + number.ToString()[1]);
            }
        }

        public int GiveDecade(int number)
        {
            if (number > 99)
            {
                return int.Parse("" + number.ToString()[1]);
            }
            else
            {
                return int.Parse("" + number.ToString()[0]);
            }
        }

        public int GiveCentury(int number)
        {
            return int.Parse("" + number.ToString()[0]);
        }
    }
}