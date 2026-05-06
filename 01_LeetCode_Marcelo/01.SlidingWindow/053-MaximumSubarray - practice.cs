//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/320345171/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _053_MaximumSubarray
    {
        /*
	        Manter a soma atual e redefinir se ela se tornar negativa.

            1. Varra o array acumulando a soma em currentSum.
                2. Se currentSum > maxSum, atualize maxSum.
                3. Se currentSum < 0, resete currentSum = 0.
         */
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return int.MinValue;

            var currentSum = nums[0];
            var maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i] + currentSum, nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
		}
    }
}
