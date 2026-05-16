//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 29.9 MB
// Link: https://leetcode.com/submissions/detail/380050584/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0268_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
			var length = nums.Length;

			//progSum = (n * (a1 + an)) / 2
			var progSum = (length * (1 + length)) / 2;
			var sum = 0;
			for (var i = 0; i < length; i++)
				sum += nums[i];

			return progSum - sum;
		}
    }
}
