namespace Blind75.Trees
{
    public static class LowestCommonAncestorofaBinarySearchTree
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var curr = root;

            while (curr != null)
            {
                if (p.val < curr.val && q.val < curr.val)
                {
                    curr = curr.left;
                }
                else if (p.val > curr.val && q.val > curr.val)
                {
                    curr = curr.right;
                }
                else
                {
                    return curr;
                }
            }

            return null;
        }
    }
}
