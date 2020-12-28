using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace source.datastructures.tree
{
    public class PreOrderTraversal{

        public string Traversal(BinaryTree root){

            if(root == null) return string.Empty;

            Stack<BinaryTree> stack = new Stack<BinaryTree>();
            stack.Push(root);
            StringBuilder sb = new StringBuilder();

            while(stack.Count > 0){

                var node = stack.Pop();
                sb.Append(node.Value + ",");

                if(node.RightChild != null){
                    stack.Push(node.RightChild);
                }

                 if(node.LeftChild != null){
                    stack.Push(node.LeftChild);
                }
            }

            return sb.ToString();

        }
    }
}
