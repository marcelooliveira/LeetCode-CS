////-----------------------------------------------------------------------------
//// Runtime: 256ms
//// Memory Usage: 33.3 MB
//// Link: https://leetcode.com/submissions/detail/375127990/
////-----------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LeetCode
//{
//    public class _056_MergeIntervals
//    {
//		/*
//56. Merge Intervals
//Given an array of intervals where intervals[i] = [starti, endi], 
//merge all overlapping intervals, and return an array of the non-overlapping 
//intervals that cover all the intervals in the input.
//Example 1:
//Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
//Output: [[1,6],[8,10],[15,18]]
//Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
//         */
//		public int[][] Merge(int[][] intervals)
//        {
//            if (intervals.Length <= 1) return intervals;

//            Array.Sort(intervals, (a, b) =>
//            {
//                var comp = a[0].CompareTo(b[0]);
//                if (comp == 0)
//                    comp = a[1].CompareTo(b[1]);
//                return comp;
//            });

//            var result = new List<int[]>();
//            result.Add(intervals[0]);
//            for (int i = 1; i < intervals.Length; i++)
//            {
//                if (result.Last()[1] >= intervals[i][0])
//                {
//                    if (result.Last()[1] < intervals[i][1])
//                        result.Last()[1] = intervals[i][1];
//                }
//                else
//                    result.Add(intervals[i]);
//            }

//            return result.ToArray(); ;
//        }
//    }
//}
