using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

https://leetcode.com/explore/featured/card/google/61/trees-and-graphs/3072/


*/
namespace source
{


public class LongestIncreasingPathSolution{

    private int M;
    private int N;
    private int[,] dirs = new int[4,2]{
        {0,1},
        {0,-1},
        {1,0},
        {-1,0}
    };
    
    public int LongestIncreasingPath(int[][] matrix) {
        
        int M = matrix.GetLength(0);
        int N = matrix[0].Length;
        int result = 0;
        
        if(M == 0) return 0;
        
        for(int i = 0; i < M ;i++){
            for(int j = 0; j < N; j++){
                result = Math.Max(result, DFS(matrix,i,j));
            }
        }   
        
        return result;
        
    }
    
    private int DFS(int[][] matrix, int i, int j){
        int result = 0;
        for( int k = 0; k < dirs.GetLength(0); k++){
            
            int dx = i + dirs[k,0];
            int dy = j + dirs[k,1];
            
            if( dx >=0 && dx < M && dy >= 0 && dy < N && matrix[dx][dy] > matrix[i][j]){
                result = Math.Max(result, DFS(matrix,dx,dy));
            }
        }
        
        return ++result;
    }

}

}