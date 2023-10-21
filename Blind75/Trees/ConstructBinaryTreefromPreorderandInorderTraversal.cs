namespace Blind75.Trees
{
    /*
    Given two integer arrays preorder and inorder where preorder is the preorder traversal 
    of a binary tree and inorder is the inorder traversal of the same tree, 
    construct and return the binary tree.
    */
    public class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        public static int[] preorder = { 3, 9, 20, 15, 7 };
        public static int[] inorder = { 9, 3, 15, 20, 7 };
        //Output: [3,9,20,null,null,15,7]

        public static TreeNode Handle()
        {
            var root = new TreeNode(preorder[0]);
            return root;
        }
    }
}
