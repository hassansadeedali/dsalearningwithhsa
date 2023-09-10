namespace Blind75.Trees
{
    public static class InvertBinaryTree
    {
        
        public static TreeNode root = new TreeNode(2, new TreeNode(1),new TreeNode(3));

        public static TreeNode Handle()
        {
            if (root == null)
                return null;

            InvertTree(root);

            return root;
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
