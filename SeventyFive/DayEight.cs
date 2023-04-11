namespace SeventyFive
{
    public class DayEight
    {
        private TreeNode prev = null;

        // #98 Validate Binary Search Tree
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (!IsValidBST(root.left) || prev != null && prev.val >= root.val)
            {
                return false;
            }

            prev = root;

            return IsValidBST(root.right);
        }

        // #235 Lowest Common Ancestor of a Binary Search Tree
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            List<TreeNode> pathToP = FindPath(root, p);
            List<TreeNode> pathToQ = FindPath(root, q);

            TreeNode lowest = null;
            if (pathToP.Count > pathToQ.Count)
            {
                lowest = FindLowestAncestor(pathToP, pathToQ);
            }
            else
            {
                lowest = FindLowestAncestor(pathToQ, pathToP);
            }
            return lowest == null ? p : lowest;
        }

        public TreeNode FindLowestAncestor(List<TreeNode> longestPath, List<TreeNode> shortestPath)
        {
            for (int i = longestPath.Count - 1; i >= 0; i--)
            {
                if (shortestPath.Contains(longestPath[i])) return longestPath[i];

            }
            return null;
        }

        public List<TreeNode> FindPath(TreeNode root, TreeNode target)
        {
            Stack<TreeNode> stack = new();
            stack.Push(root);

            List<TreeNode> pathToTarget = new();

            while (stack.Count != 0)
            {
                TreeNode curr = stack.Pop();
                pathToTarget.Add(curr);
                if (curr == null)
                {
                    pathToTarget.Clear();
                    break;
                }
                if (curr.val == target.val) break;
                if (target.val <= curr.val)
                {
                    stack.Push(curr.left);
                }
                else
                {
                    stack.Push(curr.right);
                }
            }
            return pathToTarget;

        }
    }

}
