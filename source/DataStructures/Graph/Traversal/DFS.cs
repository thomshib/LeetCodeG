using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.graph
{

public class GraphTraversal{

    /*
        BFS(S,G)
        Initialize: Queue,Visited HashSet, Parent HashMap   

        Enqueue S:
        while queue is not empty
                deque current from queue
                if current == G return parent Hashmap
                foreach of current's neighbors n, not in visited
                    add current as n's parent in ParentMap
                    add n to visited
                    Enqueue n 

        //if we get here; there is no path    



    */

    public Dictionary<Vertex<T>,Vertex<T>> BFS<T> (Graph<T> graph,  T start, T end){

        var startVertex = graph.GetVertex(start);
        var endVertex = graph.GetVertex(end);
        Dictionary<Vertex<T>,Vertex<T>> parentMap = new Dictionary<Vertex<T>,Vertex<T>>();
        HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();
        Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
        queue.Enqueue(startVertex);
        parentMap[startVertex] = null;
        visited.Add(startVertex);

        while(queue.Count >0){

            var current = queue.Dequeue();
            if(current == endVertex){
                return parentMap;
            }

            foreach(var neighbor in current.GetConnections()){
                if(!visited.Contains(neighbor)){
                    visited.Add(neighbor);
                    parentMap[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }



        return parentMap;
    }

}

}