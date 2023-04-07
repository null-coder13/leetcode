namespace SeventyFive
{
    public class DaySix
    {

        // #589. N-ary Tree Preorder Traversal
        List<int> preorder = new List<int>();

        public IList<int> Preorder(Node root)
        {
            if (root == null) return preorder;
            PrintTree(root);
            return preorder;
        }

        public void PrintTree(Node root)
        {
            preorder.Add(root.val);
            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    PrintTree(child);
                }
            }
        }

        // # 102. Binary Tree Level Order Traversal
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null) return result;

            Queue<TreeNode> order = new();
            order.Enqueue(root);

            Dictionary<TreeNode, int> levels = new();
            levels.Add(root, 0);

            while (order.Count != 0)
            {
                TreeNode curr = order.Peek();
                if (curr.left != null)
                {
                    order.Enqueue(curr.left);
                    if (!levels.ContainsKey(curr.left))
                    {
                        levels.Add(curr.left, levels[curr] + 1);
                    }
                }
                if (curr.right != null)
                {
                    order.Enqueue(curr.right);
                    if (!levels.ContainsKey(curr.right))
                    {
                        levels.Add(curr.right, levels[curr] + 1);
                    }
                }
                order.Dequeue();
            }

            int highestLevel = levels.Values.Max();

            for (int i = 0; i < highestLevel + 1; i++) {
                result.Add(new List<int>());
            }

            foreach(KeyValuePair<TreeNode, int> node in levels) {
                result[node.Value].Add(node.Key.val);
            }
            return result;
        }
    }

}
