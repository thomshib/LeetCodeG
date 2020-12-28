using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace source.datastructures.tree
{
    public class InOrderTraversal{

        public string Traversal(BinaryTree root){

            if(root == null) return string.Empty;

            Stack<BinaryTree> stack = new Stack<BinaryTree>();
            StringBuilder sb = new StringBuilder();

            while(root != null || stack.Count>0){
                while(root != null){
                    stack.Push(root);
                    root = root.LeftChild;
                }
                root = stack.Pop();
                sb.Append(root.Value + ",");

                root = root.RightChild;

            } 

            return sb.ToString();

        }

    }

}
