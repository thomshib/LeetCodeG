/*
https://runestone.academy/runestone/books/published/pythonds/Graphs/TheGraphAbstractDataType.html

    Graph() creates a new, empty graph.

addVertex(vert) adds an instance of Vertex to the graph.

addEdge(fromVert, toVert) Adds a new, directed edge to the graph that connects two vertices.

addEdge(fromVert, toVert, weight) Adds a new, weighted, directed edge to the graph that connects two vertices.

getVertex(vertKey) finds the vertex in the graph named vertKey.

getVertices() returns the list of all vertices in the graph.

in returns True for a statement of the form vertex in graph, if the given vertex is in the graph, False otherwise.





*/ 

using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.graph
{
public class Graph<T>{
     List<Vertex<T>> vertices;

     public Graph()
     {
         this.vertices = new List<Vertex<T>>();
     }

     public Vertex<T> AddVertex(T value){

         var newVertex = vertices.SingleOrDefault(item => item.Value.Equals( value));
         if(newVertex == null){
             newVertex  = new Vertex<T>(value);
             this.vertices.Add(newVertex);
         }
         
         
         return newVertex;
     }

     public Vertex<T> GetVertex(T input){
        
         return vertices.SingleOrDefault(item => item.Value.Equals(input));
     }
                    
    public void AddEdge( T from , T to, double weight=0 ){

        var fromNode = vertices.SingleOrDefault(n => n.Value.Equals(from));
        var toNode = vertices.SingleOrDefault(n => n.Value.Equals(to));

        if (fromNode == null)
            {
                fromNode = this.AddVertex(from);
            }

        if (toNode == null) 
            {
                toNode = this.AddVertex(to);
            }

         fromNode.AddNeighbor(toNode, weight);



    }

    public List<Vertex<T>> GetVertices(){
        return vertices;
    }

}

}