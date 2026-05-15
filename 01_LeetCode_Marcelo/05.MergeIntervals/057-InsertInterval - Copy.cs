//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 33.1 MB
// Link: https://leetcode.com/submissions/detail/395326352/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace LeetCode
{
    /*
57. Insert Interval
You are given an array of non-overlapping intervals intervals where 
    intervals[i] = [starti, endi] represent the start and the end of 
    the ith interval and intervals is sorted in ascending order by starti. 
    You are also given an interval newInterval = [start, end] that represents 
    the start and end of another interval.

Insert newInterval into intervals such that intervals is still sorted in ascending 
    order by starti and intervals still does not have any overlapping intervals 
    (merge overlapping intervals if necessary).

Return intervals after the insertion.

Note that you don't need to modify intervals in-place. You can make a new array 
    and return it.

 

Example 1:

Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
Example 2:

Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
     */
    public class _057_InsertInterval
    {
        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            if (intervals.Count == 0)
                return [newInterval];

            var result = new List<Interval>();


            int SearchIndex(int left, int right, int start)
            {
                var middle = (left + right) / 2;

                if (left == right)
                {
                    if (start <= intervals[left].start)
                        return left;
                    else
						return left + 1;
				}

				if (start > intervals[right].end)
					return right + 1;

				if (start <= intervals[left].start)
                    return left;

				if (start <= intervals[middle].start)
                    return SearchIndex(left, middle, start);
				
                return SearchIndex(middle + 1, right, start);
			}

            var insertIndex = SearchIndex(0, intervals.Count - 1, newInterval.start);

            var newList = new List<Interval>(intervals);

			newList.Insert(insertIndex, newInterval);

            Interval pendingInterval = newList[0];

			//merge intervals
			for (int i = 1; i < newList.Count; i++)
            {
                if (newList[i].start <= pendingInterval.end)
                    pendingInterval.end = Math.Max(newList[i].end, pendingInterval.end);
                else
                {
                    result.Add(pendingInterval);
                    pendingInterval = newList[i];
				}
            }

            result.Add(pendingInterval);

            return result;
        }
    }
}
