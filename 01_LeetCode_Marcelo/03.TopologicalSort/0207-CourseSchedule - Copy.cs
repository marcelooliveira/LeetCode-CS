////-----------------------------------------------------------------------------
//// Runtime: 116ms
//// Memory Usage: 40.2 MB
//// Link: https://leetcode.com/submissions/detail/380533385/
////-----------------------------------------------------------------------------

//namespace LeetCode
//{
//    public class _0207_CourseSchedule
//    {
//		/*
//207. Course Schedule
//There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
//You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must 
//take course bi first if you want to take course ai.

//For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
//Return true if you can finish all courses. Otherwise, return false.
//         */
//		public bool CanFinish(int numCourses, int[][] prerequisites)
//        {
//            var graph = new List<int>[numCourses];
//            var statuses = new int[numCourses];

//			//build statuses
//			for (int i = 0; i < numCourses; i++)
//			{
//				statuses[i] = 0; //pending
//				graph[i] = [];
//			}

//			//build the dependency graph (parent -> children)
//			foreach (var p in prerequisites)
//			{
//				graph[p[1]].Add(p[0]);
//			}

//			var result = true;

//			bool Navigate(List<int>[] graph, int parent)
//			{
//				if (statuses[parent] == 2) //processed
//					return true;

//				if (statuses[parent] == 1) //processing -> CYCLE!
//					return false;

//				//set as processing

//				statuses[parent] = 1;

//				foreach (var child in graph[parent])
//				{
//					if (!Navigate(graph, child))
//						return false;
//				}

//				//set as processed
//				statuses[parent] = 2;

//				return true;
//			}

//			//navigate children of each parent course
//			for (int i = 0; i < numCourses; i++)
//			{
//				result = result && Navigate(graph, i);
//			}

//			return result;
//		}
//    }
//}
