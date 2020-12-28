

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*
https://leetcode.com/explore/featured/card/google/62/recursion-4/3079/

*/
namespace source
{

    public class GenerateParenthesisSolution{
    public IList<string> GenerateParenthesis(int n) {
            
            
            var result = BFS( n);
            
            return result;
            
        }
    
    
    
    private List<String>  BFS(int n){
        List<String> result = new List<String>();
        Queue<Parenthesis> queue = new Queue<Parenthesis>();
        queue.Enqueue(new Parenthesis("",0,0));
        
        while(queue.Count > 0){
            var ps = queue.Dequeue();
            if(ps.openCount == n && ps.closeCount == n){
                result.Add(ps.value);
            }else{
                
                if(ps.openCount < n)
                    queue.Enqueue(new Parenthesis(ps.value + "(",ps.openCount + 1, ps.closeCount));
                    
                if(ps.closeCount < ps.openCount)
                    queue.Enqueue(new Parenthesis(ps.value + ")", ps.openCount, ps.closeCount + 1));    
                

            
            }
        
         }
         return result;

        }

    }






    public class Parenthesis{
    public string value;
    public int openCount;
    public int closeCount;
    public Parenthesis(string input, int open, int close){
        this.value = input;
        this.openCount = open;
        this.closeCount = close;
    }
    
}

}

