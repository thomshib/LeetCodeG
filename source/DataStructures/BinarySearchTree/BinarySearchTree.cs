using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.BST
{
    public class BinarySearchTree<T> where T:IComparable{ 
        TreeNode<T> root;
        int size;

        public BinarySearchTree()
        {
            this.root = null;
            size = 0;
        }

        public TreeNode<T> Root { get => root; set => root = value; }
        public int Size { get => size; set => size = value; }

        public void Add(T data){
            var parent = GetParent(data);
            var newNode = new TreeNode<T>(){Parent = parent,Data = data };

            if(parent == null){
                Root = newNode;

            }else if(data.CompareTo(parent.Data) < 0){
                parent.LeftChild = newNode;
            }else{
                parent.RightChild = newNode;    
            }
            Size++;
        }

        
        public  void Remove(T data){
            Remove(Root, data);
        }

        private void Remove(TreeNode<T> node, T data)
        {
            if(node == null){
                throw new ArgumentException("Data not found for deletion");

            }else if( data.CompareTo(node.Data) < 0 ){
                Remove(node.LeftChild, data);
            }else if(data.CompareTo(node.Data) >0){
                Remove(node.RightChild, data);
            }else{

                //found
                //leaf node
                if(node.LeftChild == null && node.RightChild == null){
                    ReplaceInParent(node,null);
                    Size--;
                }else if(node.LeftChild == null ){
                    ReplaceInParent(node, node.RightChild);
                    Size--;
                }else if(node.RightChild == null){
                    ReplaceInParent(node, node.LeftChild);
                    Size--;
                }else{

                        //both left and right child
                        var successor = FindMinimumInSubTree(node);
                    node.Data = successor.Data;
                    Remove(successor,successor.Data);
                }

            }
        }

       public bool Contains(T data){
           var current = Root;

           while(current != null){

               var result = data.CompareTo(current.Data);
               if(result == 0){
                   return true;
               }else if( result < 0){
                   current = current.LeftChild;
               }else{
                   current = current.RightChild;
               }
               
           }
           return false;
       }
       
       
        private TreeNode<T> FindMinimumInSubTree(TreeNode<T> node)
        {
            while(node.LeftChild != null){
                node = node.LeftChild;
            }

            return node;
        }

        private void ReplaceInParent(TreeNode<T> node, TreeNode<T> newNode)
        {
            if(node.Parent != null){
                if(node.Parent.LeftChild == node){
                    node.Parent.LeftChild = newNode;
                }else{
                    node.Parent.RightChild = newNode;
                }
            }else{
                Root = newNode;
            }

            if(newNode != null){
                newNode.Parent = node.Parent;
            }
        }

        private TreeNode<T> GetParent(T data)
        {
            TreeNode<T> current = Root;
            TreeNode<T> parent = null;

            while(current != null){
                parent = current;
                int result = data.CompareTo(current.Data);

                if(result == 0){
                    throw new ArgumentException("Node already exists with the value");
                }else if(result < 0 ){
                    current = current.LeftChild;
                }else{
                    current = current.RightChild;   
                }

                
            }

            return parent;
        }
    }

}
