namespace SeventyFive
{
    public class DayFour
    {
        // #876. Middle of the Linked List
        public ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            ListNode ahead = head.next;

            while (ahead != null)
            {
                middle = middle.next;
                if (ahead.next == null)
                {
                    break;
                }
                ahead = ahead.next.next;
            }
            return middle;
        }

        // #142. Linked List Cycle II
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();

            ListNode curr = head;
            while (curr != null)
            {
                if (!visited.Add(curr))
                {
                    return curr;
                }
                curr = curr.next;
            }
            return curr;
        }

    }

}
