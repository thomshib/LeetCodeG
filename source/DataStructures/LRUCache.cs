using System;
using System.Collections.Generic;

namespace source.datastructures
{


/*
    https://leetcode.com/problems/lru-cache/solution/

    Using HashTable and doubly linked list


*/

public class DNode{
    public string key;
    public string value;

    public DNode prev;
    public DNode next;

    public DNode(string key, string value){
        this.key = key;
        this.value = value;
        this.prev = null;
        this.next = null;
    }

    public DNode(){}
}

public class LRUCache{

    private int capacity;
    private DNode head;
    private DNode tail;

    private Dictionary<string,DNode> map;

    public LRUCache(int capacity){

        this.capacity = capacity;
        map = new Dictionary<string, DNode>();
        head = new DNode();
        tail = new DNode();
        head.next = tail;
        tail.prev = head;

    }

    private void AddNode(DNode node){

        var next = head.next;

        head.next = node;

        node.prev = head;
        node.next = next;

        next.prev = node;
    }

    private void RemoveNode(DNode node){

        var prev = node.prev;
        var next = node.next;

        prev.next = next;
        next.prev = prev;

    }

    private void MoveToHead(DNode node){

       RemoveNode(node);
       AddNode(node);   


    }

    private DNode PopTail(){

        var node = tail.prev;
        RemoveNode(node);
        return node;
    }

    private string Get(string key){

        DNode node = null;

        if(map.ContainsKey(key)){

            node = map[key];
           
        }

        if(node == null) return String.Empty;



         MoveToHead(node);
         return node.value;
    }

    private void Put(string key, string value){
        DNode node = null;

        if(map.ContainsKey(key)){
           node = map[key];
        }

        if(node == null){
            DNode newNode = new DNode(key,value);
            map.Add(key,newNode);
            AddNode(newNode);

            if(map.Count > capacity){
                var tail = PopTail();
                map.Remove(tail.key);
            }
        }else{
            node.value = value;
            MoveToHead(node);
        }
    }   




}


}

