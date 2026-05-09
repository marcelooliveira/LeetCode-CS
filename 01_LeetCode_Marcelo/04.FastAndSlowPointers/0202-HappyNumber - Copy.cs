//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 16.1 MB
// Link: https://leetcode.com/submissions/detail/261183730/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Globalization;

namespace LeetCode
{
    public class _0202_HappyNumber
    {
		/*
202. Happy Number
Easy
Topics
premium lock icon
Companies
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.
         */
		public bool IsHappy(int n)
        {
            var seen = new HashSet<int>();

            while (n > 1)
            {
                var quotient = n;
                var sum = 0;

                do
                {
                    var digit = quotient % 10;
                    quotient = quotient / 10;
					sum += digit * digit;
                }
                while (quotient > 0);

				n = sum;

                if (seen.Contains(n))
                    return false;

				seen.Add(n);
            }

            return n == 1;
        }
    }
}
