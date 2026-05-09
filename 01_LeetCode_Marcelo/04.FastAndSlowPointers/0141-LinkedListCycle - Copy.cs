//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/352953685/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) {
     *         val = x;
     *         next = null;
     *     }
     * }
     */
    public class _0141_LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head.next;

            if (slow == null || fast == null)
                return false;

			while (slow != fast)
			{
                if (slow.next == null || fast.next.next == null)
                    return false;

                slow = slow.next;
                fast = fast.next.next;
			}
            return true;
		}
    }
}
