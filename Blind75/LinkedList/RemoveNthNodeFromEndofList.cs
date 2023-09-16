namespace Blind75.LinkedList
{
    public class RemoveNthNodeFromEndofList
    {
        public static ListNode third = new ListNode(3);
        public static ListNode second = new ListNode(2, third);
        public static ListNode head = new ListNode(1, second);
        public static int n = 1;

        //Input: head = [1,2,3,4,5], n = 2
        //Output: [1,2,3,5]
        public static ListNode Handle()
        {
            var dummy = new ListNode(0, head);
            var left = dummy;
            var right = head;

            //Find head after the element to be removed
            while (n > 0)
            {
                right = right.next;
                n--;
            }

            while (right != null)
            {
                right = right.next;
                left = left.next;
            }

            left.next = left.next.next;

            return dummy.next;
        }
    }
}
