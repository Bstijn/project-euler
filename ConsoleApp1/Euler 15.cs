using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    public class Euler_15
    {
        public void Run()
        {
            List<List<Int64>> PascalsTriangle = new List<List<Int64>> { new List<Int64> { 1 }, new List<Int64> { 1, 1 }, new List<Int64> { 1, 2, 1 }};
            int i = 1;
            while(PascalsTriangle.Count < 41)
            {
                PascalsTriangle.Add(GenerateNextPascal(PascalsTriangle[i + 1]));
                i++;
            }
            foreach (List<Int64> layer in PascalsTriangle)
            {

                Console.WriteLine(layer[layer.Count / 2]);
            }
        }




        public List<Int64> GenerateNextPascal(List<Int64> prevPascal)
        {
            Int64 length = prevPascal.Count + 1;
            List<Int64> newLayer = new List<Int64>();
            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    newLayer.Add(1);
                }
                else if (i == length - 1)
                {
                    newLayer.Add(1);
                }
                else
                {
                    newLayer.Add(prevPascal[i - 1] + prevPascal[i]);
                }
            }
            return newLayer;
        }
    }
}
