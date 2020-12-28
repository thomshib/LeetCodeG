using System;
using System.Collections.Generic;
using source.datastructures.graph;

/*

https://runestone.academy/runestone/books/published/pythonds/Graphs/BuildingtheKnightsTourGraph.html
*/      


namespace source
{

public class KnightTourProblem{

    public Graph<int> BuildGraph(int boardSize){

        Graph<int> graph = new Graph<int>();

        for(int row = 0; row < boardSize; row++){
            for(int col = 0; col < boardSize; col++){
                var fromNodeId = PositionToNodeId(row,col,boardSize);
                var newMoves = GenerateLegalMove(row,col,boardSize);
                foreach(var item in newMoves){
                    var toNodeId = PositionToNodeId(item[0], item[1], boardSize);
                    graph.AddEdge(fromNodeId,toNodeId);
                }
            }
        }



        return graph;


    }

        private  List<int[]> GenerateLegalMove(int row, int col, int boardSize)
        {
            List<int[]>   moveOffsets = new List<int[]>(){
                new int[]{ -1,-2},
                new int[]{ -1,  2},
                new int[]{ -2,-1},
                new int[]{ -2, 1},
                new int[]{ 1,-2},
                new int[]{ 1, 2},
                new int[]{ 2,-1}, 
                new int[]{ 2,1}        

            };

            List<int[]> result = new List<int[]>();

            foreach(var item in moveOffsets){
                int newX = row + item[0];
                int newY = col + item[1];

                if (IsValidPostion(newX,boardSize) && IsValidPostion(newY,boardSize)){
                    result.Add(new int[]{newX, newY});
                }
            }

            return result;



        }

        private bool IsValidPostion(int X, int boardSize)
        {
           return X >= 0 && X < boardSize;
        }

        private int PositionToNodeId(int row, int col, int boardSize)
        {
            return (row * boardSize) + col;
        }
    }

}