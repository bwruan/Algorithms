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

        public void PrintLevelOrderIterative(TreeNode<int> root)
        {
            var que = new Queue<TreeNode<int>>();
            que.Enqueue(root);

            while(que.Count != 0)
            {
                TreeNode<int> temp = que.Dequeue();
                Console.Write(temp.Data + " ");

                if(temp.Left != null)
                {
                    que.Enqueue(temp.Left);
                }

                if(temp.Right != null)
                {
                    que.Enqueue(temp.Right);
                }
            }
        }
    }
}
