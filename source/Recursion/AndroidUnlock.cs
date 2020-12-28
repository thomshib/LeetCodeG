using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*
https://leetcode.com/explore/featured/card/google/62/recursion-4/484/

https://leetcode.com/problems/android-unlock-patterns/discuss/82464/Simple-and-concise-Java-solution-in-69ms

*/
namespace source
{
    public class AndriodUnlock{

        bool[] visited;
                    int[,] jumps; 

        public int NumberOfPatterns(int m, int n) {

            /*
                1 2 3
                4 5 6
                7 8 9

            */

             visited = new bool[10];

             //We can check invalid moves by using a jumping table. 
             //e.g. If a move requires a jump and the key that it is crossing is not visited, then the move is invalid. 

             jumps = new int[10,10];
             jumps[1,3] = jumps[3,1] = 2;
             jumps[1,7] = jumps[7,1] = 4;
             jumps[3,9] = jumps[9,3] = 6;
             jumps[7,9] = jumps[9,7] = 8;
             jumps[1,9] = jumps[9,1] = 5;
             jumps[3,7] = jumps[7,3] = 5;
             jumps[4,6] = jumps[6,4] = 5;
             jumps[2,8] = jumps[8,2] = 5;

             int count = 0;

             count += DFS(1,1,0,m,n) * 4; // symmetrical for 1 3  7 9 
             count += DFS(2,1,0,m,n) * 4; // symmetrical for 2 4 6 8
             count += DFS(5,1,0,m,n); 

            return count;


        
        }

            private int DFS(int num, int length, int count, int m, int n)
            {
                // only count if moves are larger than m
                if(length >= m){
                    count++;
                }
                length++;
                if(length > n){
                    return count;
                }
                visited[num] = true;

                for(int next = 1; next <= 9; next++){
                    var jump = jumps[num,next];

                    if(!visited[next]  && (jump == 0 || visited[jump])){
                        count = DFS(next, length,count, m, n);
                    }

                }

                //backtrack
                visited[num] = false;
                return count;   

            }
    }

}
