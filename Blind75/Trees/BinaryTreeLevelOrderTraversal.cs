using System.Collections.Generic;

namespace Blind75.Trees
{
    public class BinaryTreeLevelOrderTraversal
    {
        //Iterative - uses BFS
        public static TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        public static IList<IList<int>> LevelOrder()
        {
            var result = new List<IList<int>>();

            if (root == null)
                return result;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (true)
            {
                var curLevel = q.Count;
                if (curLevel == 0)
                    break;
                var curNodes = new List<int>();

                while (curLevel > 0)
                {
                    var cur = q.Dequeue();
                    curNodes.Add(cur.val);

                    if (cur.left != null)
                        q.Enqueue(cur.left);

                    if (cur.right != null)
                        q.Enqueue(cur.right);

                    curLevel--;
                }

                result.Add(curNodes);
            }

            return result;
        }
    }
}




