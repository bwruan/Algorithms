using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class LevelOrderTraversal
    {
        public void PrintLevelOrder(TreeNode<int> root, int lvl, Dictionary<int, List<TreeNode<int>>> tracker)
        {
            if(root == null)
            {
                return;
            }

            if (tracker.ContainsKey(lvl))
            {
                tracker[lvl].Add(root);
            }
            else
            {
                tracker.Add(lvl, new List<TreeNode<int>>() { root });
            }

            PrintLevelOrder(root.Left, lvl + 1, tracker);

            PrintLevelOrder(root.Right, lvl + 1, tracker);
        }
    }
}
