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
            int current = number;
            for (int i = 0; i < 5; i++)
            {
                String s = current.ToString();
                int sumOfDigitsSquared = 0;
                foreach (char c in s)
                {
                    int digit = int.Parse(c.ToString());
                    sumOfDigitsSquared += (digit * digit);
                }
                if (sumOfDigitsSquared == 1)
                {
                    return true;
                }
                current = sumOfDigitsSquared;
            }
            return false;
        }
    }
}
