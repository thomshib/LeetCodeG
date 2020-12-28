
using System;
using System.Collections.Generic;
using source.datastructures.graph;

/*

https://runestone.academy/runestone/books/published/pythonds/Graphs/TheWordLadderProblem.html

Represent the relationships between the words as a graph.

Use the graph algorithm known as breadth first search to find an efficient path from 
the starting word to the ending word.
*/
namespace source
{
    public class WordLadderProblem{

        private static Graph<string> BuildGraph(string[] words){

           

            //create bucket
            Dictionary<string,List<string>> buckets = new Dictionary<string, List<string>>();

            foreach(var word in words){

                for(int i = 0; i <word.Length; i++){
                    string key = word.Substring(0,i) + "_" + word.Substring(i+1);
                    if(!buckets.ContainsKey(key)){
                        buckets.Add(key,new List<string>());
                    }
                    buckets[key].Add(word);
                    
                    
                }
            }


            // add vertices and edges for words in the same bucket

            Graph<string> wordGraph = new Graph<string>();
            foreach(var key in buckets.Keys){
                    foreach(var word1 in buckets[key]){
                        foreach(var word2 in buckets[key]){ 
                            if(word1 != word2){
                                wordGraph.AddEdge(word1,word2);
                            }
                    }


                }

            }

            return wordGraph;



}



/*
    BFS(graph,G)
                initialize: queue, visited HashSet and parent HashMap
                Enqueue S into queue and add S to Visited
                
                while queue is not empty
                {
                    dequeue currentNode from queue
                    if currentNode == G return parentMap

                    foreach of currentNode neighbors; n not in Visited{
                            add n to Visited
                            add currentNode as parent of n in parentMap 
                            Enqueue n to the queue
                    }

                }

                //if we get here there is no path


*/
        private static bool GraphBFS(Graph<string> graph, string beginlWord,string endWord){

            var startVertex = graph.GetVertex(beginlWord);
            

            Queue<Vertex<string>> queue = new   Queue<Vertex<string>>();
            HashSet<Vertex<string>> visited = new HashSet<Vertex<string>>();
            Dictionary<Vertex<string>,Vertex<string>> parentMap = new Dictionary<Vertex<string>, Vertex<string>>();
            queue.Enqueue(startVertex);
            visited.Add(startVertex);
            parentMap[startVertex] = null;

            while(queue.Count > 0){

                var currentVertex = queue.Dequeue();
                if(currentVertex.Value == endWord) return true;

                foreach(var neighbor in currentVertex.GetConnections()){
                    if(!visited.Contains(neighbor)){
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                        if(!parentMap.ContainsKey(neighbor)){
                            parentMap.Add(neighbor,null);
                        }
                        parentMap[neighbor] = currentVertex;
                    }
                }
            }

            return false;





        }


        public static bool WordLadder(string beginWord, string endWord,string[] wordList) {

            var graph = BuildGraph(wordList);
            return GraphBFS(graph,beginWord,endWord);

        }
        
    }


}
