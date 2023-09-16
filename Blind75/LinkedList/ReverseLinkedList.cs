namespace Blind75.LinkedList
{
    public class ReverseLinkedList
    {
        public static ListNode third = new ListNode(3);
        public static ListNode second = new ListNode(2,third);
        public static ListNode head = new ListNode(1, second);
        //Input: head = [1,2,3,4,5]
        //Output: [5,4,3,2,1]
        public static ListNode Handle()
        {
            ListNode prev = null;

            while (head != null)
            {
                var temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }

            return prev;
        }
    }
}
