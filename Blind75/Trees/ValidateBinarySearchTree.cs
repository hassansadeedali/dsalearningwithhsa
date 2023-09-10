namespace Blind75.Trees
{
    class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {

            if (root == null)
                return true;

            return IsValid(root, long.MinValue, long.MaxValue);

        }

        public bool IsValid(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;

            if (!(root.val > min && root.val < max))
            {
                return false;
            }
            else
            {
                return IsValid(root.left, min, root.val) &&
                       IsValid(root.right, root.val, max);

            }
        }
    }
}
