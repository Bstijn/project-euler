using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Euler_9
    {
        public void Run()
        {
            
            bool found = false;
            Console.WriteLine("starting");
            //step 1 first make a method that finds every possible configuration of a^2 + b^2 = c^2 till 950;
            for (int i =951;  i > 1; i--) // i = c;
            {
                for(int j = 1; j < 951; j++) //j = a;
                {
                    for(int k = 1; k< 951; k++) // k =b;
                    {
                        if((i *i) == (j*j) + (k * k))
                        {
                            if(i + j +k == 1000)
                            {
                                Console.WriteLine(i * j * k);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("done");
        }
    }
}
