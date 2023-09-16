using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.LinkedList
{
    public class ReorderList
    {
        public static ListNode third = new ListNode(3);
        public static ListNode second = new ListNode(2, third);
        public static ListNode head = new ListNode(1, second);

        //Input: head = [1,2,3,4,5,6]
        //Output: [1,6,2,5,3,4]
        public static ListNode Handle()
        {
            return head;
        }
    }
}
