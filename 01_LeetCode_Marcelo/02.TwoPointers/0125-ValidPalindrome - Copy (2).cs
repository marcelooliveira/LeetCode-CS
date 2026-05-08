//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 23.6 MB
// Link: https://leetcode.com/submissions/detail/271483819/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0125_ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            var p = s.ToLower();

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(p[left]))
                    left++;

                while (left < right && !char.IsLetterOrDigit(p[right]))
                    right--;

                if (p[left] != p[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
