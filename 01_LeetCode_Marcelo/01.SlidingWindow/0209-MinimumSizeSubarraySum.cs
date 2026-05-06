//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/372037277/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0209_MinimumSizeSubarraySum
    {
		/*
         Janela dinâmica que encolhe assim que atinge a soma alvo.

            1. Expanda a janela somando elementos com o ponteiro right.
            2. Enquanto a soma for ≥ alvo, registre o menor 
                    comprimento e encolha a janela movendo left para a direita.
         */
		public int MinSubArrayLen(int s, int[] nums)
        {
            var result = int.MaxValue;
            var sum = 0;
            var left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum >= s)
                {
                    result = Math.Min(result, i - left + 1);
                    sum -= nums[left++];
                }
            }

            return result == int.MaxValue ? 0 : result;
        }
    }
}
