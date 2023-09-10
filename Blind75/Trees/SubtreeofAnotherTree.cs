namespace Blind75.Trees
{
    public static class SubtreeofAnotherTree
    {
        public static bool IsSubtree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (SameTree.IsSameTree(p, q))
            {
                return true;
            }
            else
            {
                return IsSubtree(p.left, q) || IsSubtree(p.right, q);

            }

        }
    }
