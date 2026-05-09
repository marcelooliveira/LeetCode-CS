//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 40.2 MB
// Link: https://leetcode.com/submissions/detail/380533385/
//-----------------------------------------------------------------------------

namespace LeetCode
{
	public class _0207_CourseSchedule
	{
		public bool CanFinish(int numCourses, int[][] prerequisites)
		{
			var statuses = new int[numCourses];
			var graph = new List<int>[numCourses];

			//initialize
			for (int i = 0; i < numCourses; i++)
			{
				statuses[i] = 0; //pending
				graph[i] = []; //start with no children
			}

			//populate graph
			foreach (var p in prerequisites)
			{
				graph[p[1]].Add(p[0]);
			}

			var result = true;

			//recurse each course
			for (int i = 0; i < numCourses; i++)
			{
				result = result && CanNavigate(graph, i);
			}
			return result;

			bool CanNavigate(List<int>[] graph, int parent)
			{
				if (statuses[parent] == 2) //processed
					return true;

				if (statuses[parent] == 1) //pending = CYCLE!
					return false;

				//mark course as pending before recursion
				statuses[parent] = 1;

				//recurse children
				foreach (var child in graph[parent])
				{
					if (!CanNavigate(graph, child))
						return false;
				}

				//mark course as processed after recursion
				statuses[parent] = 2;

				return true;
			}
		}
	}
}

