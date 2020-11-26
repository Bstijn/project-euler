using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Euler_17
    {
        public void Run()
        {
            int total = 0;
            for(int i = 1; i < 1001; i++)
            {
                total += CountHowManyLettersAreInWrittenOutNumber(i);
                if(i == 546)
                {
                    Console.WriteLine(CountHowManyLettersAreInWrittenOutNumber(i));
                }
            }
            Console.WriteLine(total); 
        }

        private int CountHowManyLettersAreInWrittenOutNumber(int number)
        {
            int amountOfletters = 0;
            if(number > 99 && number < 1000)
            {
                amountOfletters += 7; //Hundred
                amountOfletters += 3; // "and" that is obligitory with 100;
                amountOfletters += CountHowManyLettersInSingleDigit(int.Parse("" + number.ToString()[0])); // the century number.
                int remainingNumber = number - (int.Parse("" + number.ToString()[0]) * 100); // century number - century amount so 897 - 800;
                if(remainingNumber > 10)
                {
                    amountOfletters += CountHowManyLettersInDoubleDigit(remainingNumber);
                }
                else if(remainingNumber < 10 && remainingNumber > 0)
                {
                    amountOfletters += CountHowManyLettersInSingleDigit(remainingNumber);
                }
                else if(remainingNumber == 10)
                {
                    amountOfletters += 3;
                }
                else if(remainingNumber == 0)
                {
                    amountOfletters -= 3; // "and" because nothing is after the 100

                }
            }
            else if (number == 1000)
            {
                amountOfletters += 11;// One Thousand
            }
            else if(number > 10)
            {
                amountOfletters += CountHowManyLettersInDoubleDigit(number);
            }
            else if(number < 10 && number > 0)
            {
                amountOfletters += CountHowManyLettersInSingleDigit(number);
            }
            else if(number == 10)
            {
                amountOfletters += 3;
            }
            if(amountOfletters == 0)
            {
            }
            return amountOfletters;
           
        }

        private int CountHowManyLettersInSingleDigit(int number)
        {
            if (number > 9 && number < 1)
            {
                throw new Exception("number is not single digit");
            }
            else
            {
                switch (number)
                {
                    case 1: return 3; //one
                    case 2: return 3; //two
                    case 3: return 5; //Three
                    case 4: return 4; //Four
                    case 5: return 4; //five
                    case 6: return 3; //six
                    case 7: return 5; //seven
                    case 8: return 5; //eight
                    case 9: return 4; //nine
                    default: throw new Exception("number not single digit");
                }
            }
        }

        private int CountHowManyLettersInDoubleDigit(int number)
        {
            int amountOfLetters = 0;
            if(number < 11 && number > 99)
            {
                throw new Exception("number is not double digit");
            }
            else
            {
                if(int.Parse("" + number.ToString()[1]) != 0)
                {
                    //amountOfLetters += 1; //If double digit has a number after the tens then it will have a "-" so one letter. !!!!!!! WARNING - does not count as a letter!!!!!!!!!!!!!
                    if(number < 20 && number > 10)
                    {
                        return CountHowManyLettersInNumberWithin10(number);
                    }
                    amountOfLetters += CountHowManyLettersInSingleDigit(int.Parse("" + number.ToString()[1]));
                }
                switch (int.Parse("" + number.ToString()[0]))
                {
                    case 1: amountOfLetters +=  CountHowManyLettersInNumberWithin10(number); return amountOfLetters;
                    case 2: amountOfLetters += 6; break;//twenty
                    case 3: amountOfLetters += 6; break;//thirty
                    case 4: amountOfLetters += 5; break;//forty
                    case 5: amountOfLetters += 5; break;//fifty
                    case 6: amountOfLetters += 5; break;//sixty
                    case 7: amountOfLetters += 7; break;//seventy
                    case 8: amountOfLetters += 6; break;//eighty
                    case 9: amountOfLetters += 6; break;//ninety
                }
                return amountOfLetters;
            }
        }

        private int CountHowManyLettersInNumberWithin10(int number)
        {
            if(number > 10 && number < 20) // number needs to fall below 20 and above 10
            {
                switch (number)
                {
                    case 11: return 6; //eleven
                    case 12: return 6; //twelve
                    case 13: return 8; //thirteen
                    case 14: return 8; //fourteen
                    case 15: return 7; //fifteen
                    case 16: return 7; //sixteen
                    case 17: return 9; //seventeen
                    case 18: return 8; //eighteen
                    case 19: return 8; //nineteen
                    default: throw new Exception("this number is not involged");
                }
            }
            else
            {
                throw new Exception("Incorrect usage of fucntion");
            }
        }
    }
}
