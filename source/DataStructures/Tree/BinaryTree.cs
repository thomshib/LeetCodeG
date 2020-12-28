using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.tree
{
    public class BinaryTree{

        private string value;
        private BinaryTree leftChild;
        private BinaryTree rightChild;

        public BinaryTree(string data)
        {
            this.value = data;
            this.leftChild = null;
            this.rightChild = null;
        }

        public void InsertLeft(string value){
            if( this.leftChild == null){
                this.leftChild = new BinaryTree(value);
            }else{

                BinaryTree tree = new BinaryTree(value);
                tree.leftChild = this.leftChild;
                this.leftChild = tree;
            }
        }

        public void InsertRight(string value){
            if( this.rightChild == null){
                this.rightChild = new BinaryTree(value);
            }else{

                BinaryTree tree = new BinaryTree(value);
                tree.rightChild = this.rightChild;
                this.rightChild = tree;
            }
        } 

        public BinaryTree LeftChild{
            get{return this.leftChild;}
        }  

        public BinaryTree RightChild{
            get{return this.rightChild;}
        }

        public string Value{
            get{return this.value;}
            set{this.value = value;}
        }  

    }

}