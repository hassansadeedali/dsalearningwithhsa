using System.Collections.Generic;

namespace Blind75.Trees
{
    class KthSmallestElementinaBST
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        public int KthSmallest(TreeNode root, int k)
        {
            TraverseToEnd(root);

            TreeNode node = null; 
            while (k > 0)
            {
                //If k=1, the very first element is the answer, since this is a BST
                node = stack.Pop();
                k--;

                if (k == 0)
                    break;

                TraverseToEnd(node.right);
            }

            return node.val;
        }

        private void TraverseToEnd(TreeNode root)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }
    }
}
