using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

https://leetcode.com/problems/word-squares/solution/


*/

namespace source
{
    public class WordSquaresSolution{

        int N;
         Dictionary<string, List<string>> prefixHashTable;
         string[] words = null;


        public List<List<string>> WordSquares(string[] words) {

            if(words.Length == 0) return null;

            this.words = words;

            N = words[0].Length;

            List<List<string>> results = new List<List<string>>();

            prefixHashTable = new Dictionary<string, List<string>>();

            BuildPrefixHashTable(words);

            foreach(var word in words){
                List<string> wordList = new List<string>();
                wordList.Add(word);
                backtrack(1,wordList, results);
            }


            return results;





        
        }

        private void backtrack(int step, List<string> wordList, List<List<string>> results)
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

            if(prefixHashTable.ContainsKey(prefix)){
                foreach(var candidate in prefixHashTable[prefix]){
                    wordList.Insert(wordList.Count, candidate);
                    backtrack(step + 1, wordList, results);
                        wordList.RemoveAt(wordList.Count - 1);

                }
            }
            
        }       

        private void BuildPrefixHashTable(string[] words)
        {
            foreach(var word in words){
                for(int i = 1; i < N; i++){
                    string prefix = word.Substring(0,i);
                    if(!prefixHashTable.ContainsKey(prefix)){
                        prefixHashTable.Add(prefix, new List<string>());
                    }

                    prefixHashTable[prefix].Add(word);

                }
            }
        }



        
    }

}