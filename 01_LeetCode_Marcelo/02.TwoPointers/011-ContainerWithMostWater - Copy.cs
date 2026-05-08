////-----------------------------------------------------------------------------
//// Runtime: 104ms
//// Memory Usage: 27.5 MB
//// Link: https://leetcode.com/submissions/detail/378092152/
////-----------------------------------------------------------------------------

//using System;

//namespace LeetCode
//{
//    public class _011_ContainerWithMostWater
//    {
//		/*
//11. Container With Most Water

//You are given an integer array height of length n.
//There are n vertical lines drawn such that the two endpoints of the ith line
//        are (i, 0) and (i, height[i]).

//Find two lines that together with the x-axis form a container,
//        such that the container contains the most water.

//Return the maximum amount of water a container can store.   
        
//Notice that you may not slant the container.

//Input: height = [1,8,6,2,5,4,8,3,7]
//Output: 49
//Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
//In this case, the max area of water (blue section) the container can contain is 49.
//         */
//		public int MaxArea(int[] heights)
//        {
//            var maxArea = 0;
//			var left = 0;
//            var right = heights.Length - 1;

//            while (left < right)
//            {
//                var width = right - left;
//                var area = width * Math.Min(heights[left], heights[right]);

//                maxArea = Math.Max(maxArea, area);

//                if (heights[left] < heights[right])
//                {
//                    left++;
//				}
//                else
//				{
//					right--;
//				}
//			}

//			return maxArea;
//        }
//    }
//}
