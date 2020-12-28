using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

https://leetcode.com/problems/word-search-ii/solution/  


*/

namespace source
{
    public class WordSearchSolution{

        

        char[][] board;

         public IList<string> FindWords(char[][] board, string[] words) {


             List<string> result = new List<string>();

             TrieDS trie = new TrieDS(words);
             TNode root = trie.root;


             this.board = board;

             for(int row = 0; row < board.GetLength(0); row++){
                 for(int col = 0; col < board[row].Length; col++){
                     var letter = board[row][col];
                     if(root.children[letter - 'a'] != null){
                         BackTrack(row,col,root,result);
                     }
                 }
             }

             return result;


        
        }

        private void BackTrack(int row, int col, TNode node, List<string> result)
        {
            var letter = board[row][col];

            if( letter == '#' || node.children[letter - 'a'] == null) return;
            
            
            node = node.children[letter - 'a'];

            

            if(node.word != null){
                result.Add(node.word);
                //to avoid duplicates
                node.word = null;

            }

            board[row][col] = '#'; //to avoid revisiting

            if( row > 0) BackTrack(row - 1, col, node,result);
            if( col > 0) BackTrack(row, col - 1, node, result);
            if( row < board.GetLength(0) - 1) BackTrack(row + 1, col, node,result);
            if( col < board[0].Length - 1) BackTrack(row, col + 1, node, result);

            //backtrack
            board[row][col] = letter;


        }
    }


    public class TNode{
        public string word;
        public TNode[] children;

        public TNode(){
            this.children = new TNode[26];
        }
    }


    public class TrieDS{
        public TNode root;

        public TrieDS(string[] words){
            root = new TNode();

            foreach(var word in words){
                var current = root;
                foreach(var letter in word){

                    int idx = letter - 'a';
                    if(current.children[idx] == null){
                        TNode newNode = new TNode();
                        current.children[idx] = newNode;

                    }
                    current = current.children[idx];

                }
                current.word = word;  //assign at the end
            }
        }


        public TNode FindByPrefix(string prefix){
            var current = root;
            foreach(var letter in prefix){
                int idx = letter - 'a';
                if(current.children[idx] == null) return null;
                current = current.children[idx];
            }

            return current;
        }
    }

}