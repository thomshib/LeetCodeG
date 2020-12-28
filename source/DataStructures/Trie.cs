using System;

namespace source.datastructures
{

//https://www.youtube.com/watch?v=giiaIofn31A
//https://leetcode.com/problems/implement-trie-prefix-tree/
        

public class Trie{
    private TrieNode root;

    public Trie(){
        root = new TrieNode();
    }

    public void Insert(string words){

        var current = root;
        foreach(var letter in words){
            if( !current.ContainsKey(letter)){
                current.Put(letter, new TrieNode());
            }

            current = current.Get(letter);
        }

        current.SetEnd();
    }

    public TrieNode SearchPrefix(string word){

        var current = root;
        foreach(var letter in word){

            if(current.ContainsKey(letter)){
                current = current.Get(letter);
            }else{
                return null;
            }
        }

        return current;
    }

    public bool Search(string word){
        var node =  SearchPrefix(word);
        return node != null && node.IsEnd();
    }


}


public class TrieNode{

    private TrieNode[] children;
    bool isEnd;

    public TrieNode(){
        children = new TrieNode[26];
        isEnd = false;
    }

    public void Put(char item, TrieNode node){

        children[item - 'a'] = node;

    }

    public TrieNode Get(char item){
        return children[item - 'a'];
    }

    public bool ContainsKey(char item){
        return children[item - 'a'] != null;
    }

    public void SetEnd(){
        isEnd = true;
    }

    public bool IsEnd(){
        return isEnd;
    }   

}



}