using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinarySearchTree
    {
        public TreeNode Root {get;set;}

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int value) {
            var node = new TreeNode(value);

            if(Root == null) {
                Root = node;
                return;
            }
            var current = Root;
            while(true) {
                if(value < current.Value) {
                    if(current.Left == null) {
                        current.Left = node;
                        return;
                    }
                    current = current.Left;
                }
                else {
                    if(current.Right == null) {
                        current.Right = node;
                        return;
                    }
                    current = current.Right;
                }
            }
        }

    }
}