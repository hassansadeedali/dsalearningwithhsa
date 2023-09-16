namespace Blind75.LinkedList
{
    public class MergeTwoSortedLists
    {
        public static ListNode third = new ListNode(3);
        public static ListNode second = new ListNode(2, third);
        public static ListNode list1 = new ListNode(1, second);
        public static ListNode list2 = new ListNode(2, second);

        //Input: list1 = [1,2,4], list2 = [1,3,4]
        //Output: [1,1,2,3,4,4]

        public static ListNode Handle()
        {
            ListNode res = new ListNode();
            var tail = res;

            while(list1!=null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }

            if (list1 != null)
                tail.next = list1;
            else if (list2 != null)
                tail.next = list2;

            return res.next;
        }
    }
}
