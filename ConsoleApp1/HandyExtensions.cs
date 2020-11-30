using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class HandyExtensions
    {
        public static int CharToNumber(this char c)
        {
            return int.Parse(c.ToString());
        }
    }
}
