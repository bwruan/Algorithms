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

        public void PrintLevelOrderIterativelyLinearly(TreeNode<int> root)
        {
            if(root == null)
            {
                return;
            }

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

        public void PrintLevelOrderIterativelyByLevel(TreeNode<int> root)
        {
            if(root == null)
            {
                return;
            }

            var q = new Queue<TreeNode<int>>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                var i = q.Count;

                if(i == 0)
                {
                    break;
                }

                while (i > 0)
                {
                    TreeNode<int> temp = q.Dequeue();
                    Console.Write(temp.Data + " ");

                    if (temp.Left != null)
                    {
                        q.Enqueue(temp.Left);
                    }

                    if (temp.Right != null)
                    {
                        q.Enqueue(temp.Right);
                    }

                    i--;
                }
                Console.WriteLine();
            }
        }
    }
}
