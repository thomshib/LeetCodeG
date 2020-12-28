using System;
using System.Collections.Generic;
using source.datastructures.tree;

/*

https://runestone.academy/runestone/books/published/pythonds/Trees/ParseTree.html

*/

namespace source{

public class ParseTree{

    public static BinaryTree BuildParseTree(string input){

        var expList = input.Split(',');
        var tree = new BinaryTree(String.Empty);
        Stack<BinaryTree> stack = new Stack<BinaryTree>();
        stack.Push(tree);
        var currentTree = tree;

        foreach(var element in expList){

            switch (element){
                case "(":
                    currentTree.InsertLeft(String.Empty);
                    stack.Push(currentTree);
                    currentTree = currentTree.LeftChild;
                    break;
                
                case  "+":
                case  "-":
                case  "/":
                case  "*":
                    currentTree.Value = element;
                    currentTree.InsertRight(string.Empty);
                    stack.Push(currentTree);
                    currentTree = currentTree.RightChild;
                    break;
                
                case ")":
                    currentTree = stack.Pop();
                    break;

                default:

                    if(char.IsDigit(char.Parse(element))){
                        currentTree.Value = element;
                        var parent = stack.Pop();
                        currentTree = parent;
                    }
                    break;




            }   

            
        }
        
        return tree;
    }

}




}