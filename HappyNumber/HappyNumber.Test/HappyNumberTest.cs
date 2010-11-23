/*
 * http://codingkata.org/katas/unit/happy-number
 * http://en.wikipedia.org/wiki/Happy_number
 * 
 * A happy number is defined by the following process. Starting with any positive integer, 
 * replace the number by the sum of the squares of its digits, and repeat the process until 
 * the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not 
 * include 1. Those numbers for which this process ends in 1 are happy numbers, while those 
 * that do not end in 1 are unhappy numbers (or sad numbers).
 * */

using NUnit.Framework;

namespace HappyNumber.Test
{
    [TestFixture]
    public class HappyNumberTest
    {
        [Test]
        public void One_is_happy()
        {
            1.IsHappy().ShouldBeTrue();
        }

        [Test]
        public void Two_is_not_happy()
        {
            2.IsHappy().ShouldBeFalse();
        }

        [Test]
        public void Seven_is_happy()
        {
            7.IsHappy().ShouldBeTrue();
        }

        [Test]
        public void Digit_Test()
        {
            int[] digits = 10.Digits();
            digits.ShouldContain(1);
        }
    }
}