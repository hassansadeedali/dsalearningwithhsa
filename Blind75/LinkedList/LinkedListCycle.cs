using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.LinkedList
{
    public class LinkedListCycle
    {
        public static ListNode third = new ListNode(3);
        public static ListNode second = new ListNode(2, third);
        public static ListNode head = new ListNode(1, second);

        public static bool Handle()
        {
            var slow = head;
            var fast = head;

            while (fast!= null && fast.next != null)
            {              
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }

            return false;
        }
    }
}
