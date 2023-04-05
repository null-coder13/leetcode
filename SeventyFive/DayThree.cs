namespace SeventyFive
{
    public class DayThree
    {
        public ListNode sorted;
        public List<int> values = new();

        // #21 Merge Two Sorted Lists
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }

            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            this.AddValues(list1);
            this.AddValues(list2);

            values = values.OrderBy(x => x).ToList();

            sorted = new ListNode(values[0]);
            ListNode curr = sorted;

            for (int i = 1; i < values.Count; i++)
            {
                curr.next = new ListNode(this.values[i]);
                curr = curr.next;
            }

            return this.sorted;
        }

        public void AddValues(ListNode list)
        {
            ListNode curr = list;
            while (curr != null)
            {
                this.values.Add(curr.val);
                curr = curr.next;
            }
        }

        public Stack<int> stack = new();
        public ListNode reversed;

        // #206. Reverse Linked List
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            reversed = new(stack.Pop());
            ListNode curr = reversed;

            while (stack.Count > 0)
            {
                curr.next = new(stack.Pop());
                curr = curr.next;
            }

            return reversed;
        }

    }
}
