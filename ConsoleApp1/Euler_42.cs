using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public class Euler_42
    {
        public void Run()
        {
            List<string> words = ReadWordsFromFile();
            List<int> triangleNumbers = TriangleNumbersToX(18);
            int amount = 0;
            foreach(string word in words)
            {
                if (triangleNumbers.Contains(countWord(word)))
                {
                    amount++;
                }
            }

            Console.WriteLine(amount);
        }

        static readonly string textFile = @"C:\Users\Stijn\source\repos\ConsoleApp1\ConsoleApp1\euler41_words.txt";
        public List<string> ReadWordsFromFile()
        {
            List<string> words = new List<string>();
            string text = File.ReadAllText(textFile);
            bool wordHasBegun = false;
            string nextWord = "";
            foreach (var c in text)
            {
                if (c == '"' && !wordHasBegun)
                {
                    wordHasBegun = true;
                }
                else if (c == '"' && wordHasBegun)
                {
                    words.Add(nextWord);
                    wordHasBegun = false;
                    nextWord = "";
                }
                else if (c == ',' || c == ' ')
                {
                    //ignore
                }
                else
                {
                    nextWord += c;
                }
            }
            return words;
        }

        public int countWord(string word)
        {
            word = word.ToLower();
            int total = 0;
            foreach(char c in word)
            {
                total += LetterToAlphaticalPosition(c);
            }
            return total;
        }

        public int LetterToAlphaticalPosition(char c)
        {
            switch (c)
            {
                case 'a': return 1;
                case 'b': return 2;
                case 'c': return 3;
                case 'd': return 4;
                case 'e': return 5;
                case 'f': return 6;
                case 'g': return 7;
                case 'h': return 8;
                case 'i': return 9;
                case 'j': return 10;
                case 'k': return 11;
                case 'l': return 12;
                case 'm': return 13;
                case 'n': return 14;
                case 'o': return 15;
                case 'p': return 16;
                case 'q': return 17;
                case 'r': return 18;
                case 's': return 19;
                case 't': return 20;
                case 'u': return 21;
                case 'v': return 22;
                case 'w': return 23;
                case 'x': return 24;
                case 'y': return 25;
                case 'z': return 26;
                default: throw new Exception("the character: " + c + " is not in the alphabet");
            }
        }


        public List<int> TriangleNumbersToX(int x)
        {
            List<int> tns = new List<int>();
            for(int i =1; i<= x; i++)
            {
                tns.Add(trianleOfNumber(i));
            }
            return tns;
        }

        public int trianleOfNumber(int n)
        {
            return Convert.ToInt32((0.5*Convert.ToDouble(n)) *(n + 1));
        }


    }
}
