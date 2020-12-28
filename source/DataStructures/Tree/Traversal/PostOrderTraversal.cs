using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace source.datastructures.tree
{
    public class PostOrderTraversal{

        public string Traversal(BinaryTree root){

            Stack<BinaryTree> fristStack = new Stack<BinaryTree>();
            Stack<BinaryTree> secondStack = new Stack<BinaryTree>();
            fristStack.Push(root);

            while(fristStack.Count > 0){
                var node = fristStack.Pop();
                secondStack.Push(node);

                if(node.LeftChild != null){
                    fristStack.Push(node.LeftChild);

                }

                 if(node.RightChild != null){
                    fristStack.Push(node.RightChild );
                    
                }
            }

            StringBuilder sb = new StringBuilder();
            while(secondStack.Count>0){
                sb.Append(secondStack.Pop().Value + ",");
            }

            return sb.ToString();
        }
    }
}