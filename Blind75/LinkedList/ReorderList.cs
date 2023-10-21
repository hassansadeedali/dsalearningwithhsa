namespace Blind75.LinkedList
{
     /*
     You are given the head of a singly linked-list. 
     The list can be represented as:
     L0 → L1 → … → Ln - 1 → Ln
     
     Reorder the list to be on the following form:
     L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
     
     You may not modify the values in the list's nodes. Only nodes themselves may be changed.
     */
    public class ReorderList
    {
        public static ListNode head = new ListNode(1, new ListNode(2, new ListNode(3)));

        //Input: head = [1,2,3,4,5,6]
        //Output: [1,6,2,5,3,4]
        public static ListNode Handle()
        {
            //Find middle
            var slow = head;
            var fast = head.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //Reverse Second half
            var mid = slow.next;
            slow.next = null;
            ListNode revMid = null;
            while (mid != null)
            {
                var temp = mid.next;
                mid.next = revMid;
                revMid = mid;
                mid = temp;
            }

            //Merge first and second half
            var first = head;
            var second = revMid;

            while (second != null)
            {
                var temp1 = first.next;     //2-3-4-5-6
                var temp2 = second.next;    //5-4
                first.next = second;        //1-6-5-4
                second.next = temp1;        //6-2-3-4-5-6
                first = temp1;              //2-3-4-5-6
                second = temp2;             //5-4
            }

            return head;
        }
    }
}
