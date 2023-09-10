using System;

namespace Blind75.Trees
{
    public static class MaximumDepthofBinaryTree
    {
        public static TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));

        public static int Handle()
        {
            if (root == null)
                return 0;

            return MaxDepth(root);

        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return 1 + Math.Max(left, right);

        }

    }
}
