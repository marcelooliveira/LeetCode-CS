//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/402791512/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _041_FirstMissingPositive
    {
        /*
41. First Missing Positive
Given an unsorted integer array nums.
Return the smallest positive integer that is not present in nums.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

 

Example 1:

Input: nums = [1,2,0]
Output: 3
Explanation: The numbers in the range [1,2] are all in the array.
Example 2:

Input: nums = [3,4,-1,1]
Output: 2
Explanation: 1 is in the array but 2 is missing.
Example 3:

Input: nums = [7,8,9,11,12]
Output: 1
Explanation: The smallest positive integer 1 is missing.
         */
        public int FirstMissingPositive(int[] nums)
        {
			for (int i = 0; i < nums.Length; i++)
			{
				//if nums[i] falls into [1, n], swap nums[i] with nums[nums[i] - 1] until they're the same
				while (nums[i] > 0 && nums[i] <= nums.Length //nums[i] falls into [1, n]
					&& nums[i] != nums[nums[i] - 1] ) //until nums[i] with nums[nums[i] - 1] are the same
				{
					var thisIndex = i;
					var thatIndex = nums[i] - 1;

					var aux = nums[thisIndex];
					nums[thisIndex] = nums[thatIndex];
					nums[thatIndex] = aux;
				}
			}

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != i + 1)
					return i + 1; //misplaced, hence missing
			}

			return nums.Length + 1; //all included
		}
	}
}
