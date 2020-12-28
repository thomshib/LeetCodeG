using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*
https://leetcode.com/problems/count-complete-tree-nodes/solution/



*/
namespace source
{

    public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;   
      }
  }

    public class CountCompleteNodes{
         public int CountNodes(TreeNode root) {

            if(root == null) return 0;
            int depth = CountDepth(root);
            if(depth == 0) return 1;

             int left = 1;
             int right = (int) Math.Pow(2,depth)  - 1;

             int mid = 0;


            
            
             while(left <= right){

                 mid = left + (right-left) / 2;

                 if( Exists(root,mid,depth) ){
                     left = mid + 1;
                 }else{
                     right = mid - 1;;
                 }


             }

            //penultime level count + lastlevel
            return (int) Math.Pow(2,depth)  - 1 + left;

         
         }

         private int CountDepth(TreeNode node){

             int count = 0;
             while(node.left != null ){
                count++;
                node = node.left;
             }

             return count;
         }

         private bool Exists(TreeNode node, int index, int depth){
             //last level can have 1 to 2 ** depth nodes
             //Last level nodes are enumerated from 0 to 2 ** depth - 1 (left -> right).

             int left = 0;
             int right = (int) Math.Pow(2,depth)  - 1;

             int mid = 0;

            ////for each level from root
            for(int i = 0; i < depth; i++){

                 mid = left + (right-left) / 2;

                 if(index <= mid){
                     node = node.left;
                     right = mid;
                 }else {
                     node = node.right;
                     left = mid + 1;
                 }
             }

             return node != null;

         }


    }

}