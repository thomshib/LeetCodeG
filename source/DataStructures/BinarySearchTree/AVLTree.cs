using System;
using System.Collections.Generic;
using System.Linq;

/*

https://www.geeksforgeeks.org/avl-tree-set-1-insertion/#:~:text=AVL%20tree%20is%20a%20self,than%20or%20equal%20to%201

*/

namespace source.datastructures.BST
{
    public class AVLTree<T> where T:IComparable{ 

        TreeNode<T> root;

        private int Height(TreeNode<T> node){
            if(node == null) return 0;
            else return node.Height;
        }

        private TreeNode<T> RightRotate(TreeNode<T> y){

            TreeNode<T> x = y.LeftChild;
            TreeNode<T> t2 = x.RightChild;

            //Rotate
            x.RightChild = y;
            y.LeftChild = t2;

            y.Height = 1 + Math.Max(Height(y.LeftChild), Height(y.RightChild));
            x.Height = 1 + Math.Max(Height(x.LeftChild), Height(x.RightChild));


            //return new root
            return x;

        }


        private TreeNode<T> LeftRotate(TreeNode<T> x){
            TreeNode<T> y = x.RightChild;
            TreeNode<T> t2 = y.LeftChild;

            //rotate
            y.LeftChild = x;
            x.RightChild = t2;

            y.Height = 1 + Math.Max(Height(y.LeftChild), Height(y.RightChild));
            x.Height = 1 + Math.Max(Height(x.LeftChild), Height(x.RightChild));

            //return new root
            return y;
        }

        public int GetHeightDifference(TreeNode<T> node){
            
            if( node == null) return 0;
            else{
                return Height(node.LeftChild) - Height(node.RightChild);
            }
        }

        public TreeNode<T> Add( TreeNode<T> node, T data){


                //perform BST insertions

                if(node == null)
                {
                    return node = new TreeNode<T>(){Data = data};

                }

                if(data.CompareTo(node.Data) < 0){
                    node.LeftChild = Add(node.LeftChild,data);  
                }else if(data.CompareTo(node.Data) >0){
                    node.RightChild = Add(node.RightChild,data);
                }else{
                    return node;
                }

                //update the height of the ancestor
                node.Height = 1 + Math.Max(Height(node.LeftChild), Height(node.RightChild));

                //get the balance factor of the ancestor node

                int balance = Height(node.LeftChild) - Height(node.RightChild);


                //balance > 1 ; Left Left and Left Right Case

                if(balance >1){

                    //left left case
                    if(data.CompareTo(node.LeftChild.Data) < 0 ){
                        return RightRotate(node);
                    }else{
                        //left right case
                        node.LeftChild = LeftRotate(node.LeftChild);
                        return RightRotate(node);
                    }
                }


                //Right Right and Right Left case
                 if(balance < -1){

                    //right right case
                    if(data.CompareTo(node.RightChild.Data) > 0 ){
                        return LeftRotate(node);
                    }else{
                        //right left case
                        node.RightChild = RightRotate(node.RightChild);
                        return LeftRotate(node);
                    }
                }

                return node;

                
        }



    }

}