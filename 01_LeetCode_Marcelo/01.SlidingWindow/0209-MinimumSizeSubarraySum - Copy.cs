////-----------------------------------------------------------------------------
//// Runtime: 100ms
//// Memory Usage: 25.2 MB
//// Link: https://leetcode.com/submissions/detail/372037277/
////-----------------------------------------------------------------------------

//using System;

//namespace LeetCode
//{
//    public class _0209_MinimumSizeSubarraySum
//    {
//		/*
//Given an array of positive integers NUMS and a positive integer TARGET, 
//return the MINIMAL LENGTH of a subarray whose SUM is greater than or equal to target.
//If there is no such subarray, return 0 (MINIMAL LENGTH) instead.

//Example 1:

//Input: target = 7, nums = [2,3,1,2,4,3]
//Output: 2
//Explanation: The subarray [4,3] has the minimal length under the problem constraint.
//         */

//		public int MinSubArrayLen(int target, int[] nums)
//        {
//            var minLength = int.MaxValue;
//            var sum = 0;
//			var left = 0;

//			for (int i = 0; i < nums.Length; i++)
//			{
//				sum += nums[i];

//				while (sum >= target)
//				{
//					minLength = Math.Min(minLength, i - left + 1);
//					sum -= nums[left++];
//				}
//			}

//			return minLength == int.MaxValue ? 0 : minLength;
//		}
//    }
//}
