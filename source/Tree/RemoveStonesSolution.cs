
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

    https://leetcode.com/problems/most-stones-removed-with-same-row-or-column/solution/
*/

namespace source
{


    public class RemoveStonesolution            
    {
         public int RemoveStones(int[][] stones) {

             int N = stones.GetLength(0);

             DSU dsu = new DSU(6);

             for(int i = 0; i < N; i++){
                 var pair = stones[i];
                 dsu.Union(pair[0], pair[1] + 3);
             }

             HashSet<int> seen = new HashSet<int>();

             for(int i = 0; i < N; i++){
                 seen.Add( dsu.find(stones[i][0] ));    
             }

             return N - seen.Count;




        
        }       
    }



    public class DSU{
        int[] parent;
        public DSU(int size){
            parent = new int[size];

            for(int i=0; i < size; i++){
                parent[i] = i;
            }
        }

        public int find(int x){
           if(parent[x] != x) parent[x] = find(parent[x]);
           return parent[x];
               
        }

        public void Union(int x, int y){

            parent[find(x)] = find(y);
        }
    }

}