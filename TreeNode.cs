using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class TreeNode
    {
        public int Value{get;set;}
        public TreeNode Left {get;set;}
        public TreeNode Right {get;set;}

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}