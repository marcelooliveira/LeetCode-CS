//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 33.3 MB
// Link: https://leetcode.com/submissions/detail/375127990/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _056_MergeIntervals
    {
		/*
56. Merge Intervals
Given an array of intervals where intervals[i] = [starti, endi], 
    merge all overlapping intervals, and return an array of the non-overlapping intervals 
    that cover all the intervals in the input.
Example 1:
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
         */
		public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return [];

            //sort intervals

            Array.Sort(intervals, (a, b) =>
            {
                if (a[0] < b[0])
                    return -1;
                else if (a[0] > b[0])
                    return 1;
                else
                    return 0;
			});

            var result = new List<int[]>();

            var pendingInterval = new int[2] { intervals[0][0], intervals[0][1] };

			for (int i = 1; i < intervals.Length; i++)
			{
                if (intervals[i][0] <= pendingInterval[1])
                {
                    pendingInterval[1] = Math.Max(pendingInterval[1], intervals[i][1]); //enlarging pending interval
                }
                else
                {
                    result.Add(pendingInterval);
                    pendingInterval = intervals[i];
                }
			}
            result.Add(pendingInterval);

            return result.ToArray();
		}
    }
}
