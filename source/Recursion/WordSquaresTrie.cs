using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

https://leetcode.com/problems/word-squares/solution/

https://leetcode.com/problems/word-squares/discuss/91333/Explained.-My-Java-solution-using-Trie-126ms-1616


*/

namespace source
{
    public class WordSquaresTrieSolution{

         int N;

        public List<List<string>> WordSquares(string[] words) {

           if(words.Length == 0) return null;

           List<List<string>>  results = new List<List<string>>();

           N = words[0].Length;

           Trie trie = new Trie(words);

           foreach(var word in words){
               List<string> wordList = new List<string>();
               wordList.Add(word);
               backtrack(1,wordList,trie,results);
           }




           return results;





        
        }

        private void backtrack(int step, List<string> wordList, Trie trie, List<List<string>> results)
        {
            if(step == N){
                results.Add(new List<string>(wordList));
                return;
            }

            StringBuilder prefixSb = new StringBuilder();
            foreach(var word in wordList){
                prefixSb.Append(word[step]); 
            }

            var prefix = prefixSb.ToString();

            List<string> startsWithList = trie.FindByPrefix(prefix);

            
                foreach(var candidate in startsWithList){
                    wordList.Add(candidate);
                    backtrack(step + 1, wordList, trie,results);
                    wordList.RemoveAt(wordList.Count - 1);

                
            }
            
        }       


        
    }



    public class TrieNode {

        public List<string> startsWith;
        public TrieNode[] children;

        public TrieNode(){
            startsWith = new List<string>();
            children = new TrieNode[26];
        }

    }


    public class Trie{

        TrieNode root;

        public Trie(string[] words){
            root = new TrieNode();

            foreach(var word in words){
                var current = root;
                
                foreach(var letter in word){
                    int idx = letter - 'a';
                    if(current.children[idx] == null){
                        var newNode = new TrieNode();
                        current.children[idx] = newNode;
                    }
                    current.children[idx].startsWith.Add(word);
                    current = current.children[idx];

                }
            }
        }

        public List<string> FindByPrefix(string prefix){
            List<string> result = new List<string>();
            var current = root;
            foreach(var letter in prefix){
                int idx = letter - 'a';
                if(current.children[idx] == null) return result;
                current = current.children[idx];
            }

            result = new List<string>(current.startsWith);
            return result;
        }
    }

}