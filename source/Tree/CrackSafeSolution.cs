
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

   https://leetcode.com/explore/featured/card/google/61/trees-and-graphs/3075/

   https://leetcode.com/problems/cracking-the-safe/discuss/153039/DFS-with-Explanations

   We reuse last n-1 digits of the input-so-far password as below:

        e.g., n = 2, k = 2
        all 2-length combinations on [0, 1]: 
        00 (`00`110), 
         01 (0`01`10), 
          11 (00`11`0), 
           10 (001`10`)
        
        the password is 00110

        We can utilize DFS to find the password:

        goal: to find the shortest input password such that each possible n-length combination of digits 
        [0..k-1] occurs exactly once as a substring.

        node: current input password

        edge: if the last n - 1 digits of node1 can be transformed to node2 by appending a digit from 0..k-1, there will be an edge between node1 and node2

        start node: n repeated 0's
        end node: all n-length combinations among digits 0..k-1 are visited

        visitedComb: all combinations that have been visited


*/
namespace source
{


public class CrackSafeSolution
{
    HashSet<string> seen;
    StringBuilder result;
    public string CrackSafe(int n, int k) {

        if( n == 1  && k == 1 ) return "0";
        seen = new HashSet<string>();
        result = new StringBuilder();

        StringBuilder sb = new StringBuilder();

        //fill 0  n-1 times
        for(int i = 0; i < n-1; i++){
            sb.Append("0");
        }

        string start = sb.ToString();
        DFS(start,k);
        result.Append(start);
        return result.ToString();




        
    }

        private void DFS(string start, int k)
        {
            for(int i = 0 ; i < k; i++){
                String newStr = start + i;
                if(!seen.Contains(newStr)){
                    seen.Add(newStr);
                    DFS(newStr.Substring(1), k); //01 -> 1; 10 -> 0 
                    result.Append(i);
                }     
            }
        }
    }

}

