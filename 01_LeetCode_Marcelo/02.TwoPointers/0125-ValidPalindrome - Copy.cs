////-----------------------------------------------------------------------------
//// Runtime: 76ms
//// Memory Usage: 23.6 MB
//// Link: https://leetcode.com/submissions/detail/271483819/
////-----------------------------------------------------------------------------

//namespace LeetCode
//{
//    public class _0125_ValidPalindrome
//    {
//		/*
//A phrase is a palindrome if, after converting all uppercase letters into 
//        lowercase letters and removing all non-alphanumeric characters,
//        it reads the same forward and backward.
//        Alphanumeric characters include letters and numbers.
//Given a string s, return true if it is a palindrome, or false otherwise.

//Input: s = "A man, a plan, a canal: Panama"
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.
//         */
//		public bool IsPalindrome(string s)
//        {
//            const string ValidChars = "abcdefghijklmnopqrstuvwxyz0123456789";
//            var left = 0;
//            var right = s.Length - 1;
//            var p = s.ToLower();

//            while (left < right)
//            {
//                while (!ValidChars.Contains(p[left]))
//                    left++;

//                while (!ValidChars.Contains(p[right]))
//                    right--;

//                if (p[left] != p[right])
//                {
//                    return false;
//                }

//                left++;
//                right--;
//            } 

//            return true;
//		}
//    }
//}
