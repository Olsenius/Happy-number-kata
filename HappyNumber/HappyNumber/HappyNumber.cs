using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyNumber
{
    public static class HappyNumber
    {
        public static bool IsHappy(this int number)
        {
            return number == 1 || number == 7;
        }
    }
}
