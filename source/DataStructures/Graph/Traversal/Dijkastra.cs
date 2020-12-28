using System;
using System.Collections.Generic;
using System.Linq;
using source.datastructures.heap;

namespace source.datastructures.graph
{

public class DijkastraTraversal{

    /*
        Dijkastra(S,G):
            Initialize PriorityQueue PQ,visited HashSet,parent HashMap.
            Initialize distances to infinity

            Enqueue {S,0} to PQ
            while PQ is not empty
                Dequeue current node from PQ
                if current is not visited, add to visited
                if current == G return parentMap
                foreach of current's neighbors, n, not in visited
                    if path thru current to n is shorter
                        update current as parent of n
                        Enqueue {n,distance} to PQ


            //if we get here  there is no path



    */

    public (int, Dictionary<Vertex<T>,Vertex<T>>) Dijkastra<T>(Graph<T> graph,  Vertex<T> startVertex){
        int N = graph.GetVertices().Count;

        Dictionary<Vertex<T> , int> distance = new Dictionary<Vertex<T>, int>();
        Dictionary<Vertex<T>,Vertex<T>> parentMap = new Dictionary<Vertex<T>, Vertex<T>>();
        PriorityQueue<Vertex<T>,int> priorityQueue = new PriorityQueue<Vertex<T>, int>();
        HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();
        int totalDistance = 0;

        foreach (var item in graph.GetVertices())
        {
            distance[item] = int.MaxValue;
        }

        distance[startVertex] = 0;
        priorityQueue.Enqueue(startVertex,distance[startVertex]);

        while(!priorityQueue.IsEmpty()){

            var currentVertex = priorityQueue.Dequeue();

            if(!visited.Contains(currentVertex)){
                visited.Add(currentVertex);

                foreach(var neighbor in currentVertex.GetConnections()){
                    var newDistance = distance[currentVertex] + (int) currentVertex.GetWeight(neighbor);
                    if(newDistance < distance[neighbor]){
                        distance[neighbor] = newDistance;
                        totalDistance += newDistance;
                        priorityQueue.Enqueue(neighbor, distance[neighbor]);
                        parentMap[neighbor] = currentVertex;
                    }
                }

            }
        }

        return (totalDistance, parentMap);





    }

}

}