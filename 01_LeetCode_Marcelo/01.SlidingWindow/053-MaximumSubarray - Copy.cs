////-----------------------------------------------------------------------------
//// Runtime: 88ms
//// Memory Usage: 25 MB
//// Link: https://leetcode.com/submissions/detail/320345171/
////-----------------------------------------------------------------------------

//using System;

//namespace LeetCode
//{
//    public class _053_MaximumSubarray
//    {
//		/*
//Given an integer array nums, find the subarray with the largest sum, and return its sum.
//Example 1:
//Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
//Output: 6
//Explanation: The subarray [4,-1,2,1] has the largest sum 6.
//         */
//		public int MaxSubArray(int[] nums)
//        {
//            var largestSum = nums[0];
//			var currentSum = nums[0];

//			for (int i = 1; i < nums.Length; i++)
//			{
//				currentSum = Math.Max(nums[i], currentSum + nums[i]);

//				largestSum = Math.Max(largestSum, currentSum);
//			}

//			return largestSum;
//        }
//    }
//}
