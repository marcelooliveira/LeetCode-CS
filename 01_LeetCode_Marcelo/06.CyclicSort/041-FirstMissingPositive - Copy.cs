////-----------------------------------------------------------------------------
//// Runtime: 84ms
//// Memory Usage: 25.2 MB
//// Link: https://leetcode.com/submissions/detail/402791512/
////-----------------------------------------------------------------------------

//namespace LeetCode
//{
//    public class _041_FirstMissingPositive
//    {
//        /*
//41. First Missing Positive
//Given an unsorted integer array nums.
//Return the smallest positive integer that is not present in nums.

//You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

 

//Example 1:

//Input: nums = [1,2,0]
//Output: 3
//Explanation: The numbers in the range [1,2] are all in the array.
//Example 2:

//Input: nums = [3,4,-1,1]
//Output: 2
//Explanation: 1 is in the array but 2 is missing.
//Example 3:

//Input: nums = [7,8,9,11,12]
//Output: 1
//Explanation: The smallest positive integer 1 is missing.
//         */
//        public int FirstMissingPositive(int[] nums)
//        {
//            var copy = (int[])nums.Clone();

//            Array.Sort(copy, (a, b) =>
//            {
//                if (a < b)
//                    return -1;
//                if (a > b)
//                    return 1;
//                return 0;
//            });

//            var next = 1;
//			for (int i = 0; i < copy.Length; i++)
//			{
//                if (copy[i] > next)
//                    return next;

//                if (copy[i] == next)
//                    next++;
//			}

//            return next;
//		}
//	}
//}
