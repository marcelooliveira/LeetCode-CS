//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 46 MB
// Link: https://leetcode.com/submissions/detail/368357900/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0210_CourseSchedule
    {
		/*
210. Course Schedule II
Medium
Topics
premium lock icon
Companies
Hint
There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.

For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return the ordering of courses you should take to finish all courses. If there are many valid answers, return any of them. If it is impossible to finish all courses, return an empty array.

 

Example 1:

Input: numCourses = 2, prerequisites = [[1,0]]
Output: [0,1]
Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So the correct course order is [0,1].
		 */
		public int[] CanFinish(int numCourses, int[][] prerequisites)
        {
            var graph = new List<int>[numCourses];
            var statuses = new int[numCourses];

			//initialize
			for (int i = 0; i < numCourses; i++)
			{
                graph[i] = [];
                statuses[i] = 0; //pending
			}

			foreach (var p in prerequisites)
			{
				graph[p[1]].Add(p[0]);
			}

			List<int> result = [];

			bool BuildSequence(List<int>[] graph, int parent)
			{
				if (statuses[parent] == 2) //processed
					return true;
				if (statuses[parent] == 1) //pending = cycle!
					return false;

				//mark as pending
				statuses[parent] = 1;

				foreach (var child in graph[parent])
				{
					if (!BuildSequence(graph, child))
						return false;
				}

				//mark as processed
				statuses[parent] = 2;

				result.Add(parent);
				return true;
			}

			//navigate from each course
			for (int i = 0; i < numCourses; i++)
			{
				if (statuses[i] == 0 && !BuildSequence(graph, i))
				{
					return [];
				}
			}

			result.Reverse();
			return result.ToArray();
		}
    }
}
