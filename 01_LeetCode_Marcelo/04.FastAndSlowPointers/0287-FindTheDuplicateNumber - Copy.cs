//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/261902358/
//-----------------------------------------------------------------------------

namespace LeetCode
{
	public class _0287_FindTheDuplicateNumber
	{
		/*
287. Find the Duplicate Number
Given an array of integers nums containing n + 1 integers where each integer
is in the range [1, n] inclusive.

There is only one repeated number in nums, return this repeated number.
You must solve the problem without modifying the array nums and using only 
constant extra space. 

Example 1:

Input: nums = [1,3,4,2,2]
Output: 2
Example 2:

Input: nums = [3,1,3,4,2]
Output: 3
Example 3:

Input: nums = [3,3,3,3,3]
Output: 3

SOLUÇÃO: Floyd's Cycle Detection (Tartaruga e Lebre)
======================================================

IDEIA CHAVE:
- Tratar a array como uma linked list onde nums[i] aponta para o próximo nó
- Como valores estão em [1, n] e há n+1 elementos, SEMPRE há um ciclo
- O número duplicado é o PONTO DE ENTRADA do ciclo

EXEMPLO: nums = [1, 3, 4, 2, 2]
			   índices: 0  1  2  3  4

Visualização como linked list:
0 -> 1 -> 3 -> 2 -> 4
		  ↑         |
		  |_________|  (ciclo no 2)

O 2 aparece 2x → índice 2 é acessado de múltiplos lugares → entrada do ciclo
		 */
		public int FindDuplicate(int[] nums)
		{
			var slow = nums[0];
			var fast = nums[0];

			do
			{
				slow = nums[slow];
				fast = nums[nums[fast]];
			} while (slow != fast);


			var ptr1 = nums[0];
			var ptr2 = slow;

			while (ptr1 != ptr2)
			{
				ptr1 = nums[ptr1];
				ptr2 = nums[ptr2];
			}

			return ptr1;
		}
	}
}
