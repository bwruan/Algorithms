using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class PotentialCousin
    {
        public int Level;
        public TreeNode<int> Parent;
        public TreeNode<int> CousinNode;

        public PotentialCousin(int level, TreeNode<int> parent, TreeNode<int> cousin)
        {
            Level = level;
            Parent = parent;
            CousinNode = cousin;
        }
    }
}
