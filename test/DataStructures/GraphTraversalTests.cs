using System;
using Xunit;
using source.datastructures.graph;
using System.Text;

namespace test
{
    public class HashMapTests
    {
        [Fact]
        public void GrpahBFSBasicTests(){

            Graph<string> graph = new Graph<string>();
            graph.AddEdge("fool", "pool");
            graph.AddEdge("pool",  "poll");
            graph.AddEdge("fool","foil");
            graph.AddEdge("foil","fail");

            string expetectedResult = String.Empty + ",pool,fool"; 

            var result = new GraphTraversal().BFS<string>(graph,"fool","poll");

           
        

            Assert.NotNull(result);




        }


         //[Fact]
        public void GraphDijkastraTests(){

            Graph<string> graph = new Graph<string>();
            graph.AddEdge("1", "2",2);
            graph.AddEdge("2","4",7);
            graph.AddEdge("4","6",1);
            graph.AddEdge("1","3",4);
            graph.AddEdge("3","5",3);
            graph.AddEdge("5","6",5);
            graph.AddEdge("2","3",1);
            graph.AddEdge("5","4",2);

            var startVertex = graph.GetVertex("1");


            string expetectedResult = String.Empty + ",pool,fool"; 

            var (distance, map) = new DijkastraTraversal().Dijkastra<string>(graph,startVertex);

           
        
            Assert.Equal(9,distance);
            Assert.NotNull(map);




        }

    }
}