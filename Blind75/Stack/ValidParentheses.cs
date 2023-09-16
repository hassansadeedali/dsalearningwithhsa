using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Stack
{
    /*
     Given a string s containing just the characters 
    '(', ')', '{', '}', '[' and ']', determine if the 
    input string is valid.
    
    An input string is valid if:
    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.
     */
    public class ValidParentheses
    {
        // read input
        //public static readonly string s = "()[]{}";
        public static readonly string s = "(]";   //output : false
        public static bool Handle()
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>()
            {
                [')'] = '(',
                ['}'] = '{',
                [']'] = '['
            };

            foreach(var ch in s)
            {
                //Opening brackets are checked and pushed into stack
                if (!dict.ContainsKey(ch))
                {
                    stack.Push(ch);
                }
                else 
                {
                    // This is the case where we have closing bracket first
                    // before the opening bracket
                    if (stack.Count == 0)
                        return false;

                    //Closing brackets are compared by popping the stack
                    //(stack has opening bracket)
                    var value = stack.Pop();
                    if (value != dict[ch])
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
