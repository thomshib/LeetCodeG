using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.BST
{
    public class TreeNode<T>{

        T data;
        TreeNode<T> leftChild;
        TreeNode<T> rightChild;
        TreeNode<T> parent;
        int height;

         public TreeNode(){

         }

        public TreeNode(TreeNode<T> leftChild, TreeNode<T> rightChild, TreeNode<T> parent, T data)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
            this.parent = parent;
            this.data = data;
            height = 1;
        }

     

    public TreeNode<T> LeftChild { get => leftChild; set => leftChild = value; }
    public TreeNode<T> RightChild { get => rightChild; set => rightChild = value; }
    public TreeNode<T> Parent { get => parent; set => parent = value; }
    public T Data { get => data; set => data = value; }
    public int Height { get => height; set => height = value; }

    }
}

