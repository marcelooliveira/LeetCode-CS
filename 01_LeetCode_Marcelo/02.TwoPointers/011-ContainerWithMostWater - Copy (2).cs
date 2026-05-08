//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 27.5 MB
// Link: https://leetcode.com/submissions/detail/378092152/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _011_ContainerWithMostWater
    {
        public int MaxArea(int[] heights)
        {
            var maxArea = 0;
            var left = 0;
            var right = heights.Length - 1;

            while (left < right)
            {
                var width = right - left;
                var area = width * Math.Min(heights[left], heights[right]);
                maxArea = Math.Max(maxArea, area);

                if (heights[left] < heights[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
