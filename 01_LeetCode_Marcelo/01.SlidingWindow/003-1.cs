////-----------------------------------------------------------------------------
//// Runtime: 80ms
//// Memory Usage: 25.8 MB
//// Link: https://leetcode.com/submissions/detail/375123949/
////-----------------------------------------------------------------------------

//using System.Collections.Generic;

//namespace LeetCode
//{
//    public class _003_LongestSubstringWithoutRepeatingCharacters
//    {
//		public int LengthOfLongestSubstring(string s)
//        {
//			var maxLen = 0;
//			var map = new Dictionary<char, int>();
//			var left = 0;

//			for (int i = 0; i < s.Length; i++)
//			{
//				var ch = s[i];

//				if (map.ContainsKey(ch) && map[ch] >= left)
//				{
//					left = map[ch] + 1;
//				}

//				map[ch] = i;

//				if (i - left + 1 > maxLen)
//					maxLen = i - left + 1;
//			}

//			return maxLen;
//		}
//    }
//}
