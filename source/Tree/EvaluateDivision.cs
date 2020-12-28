using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

    https://leetcode.com/explore/featured/card/google/61/trees-and-graphs/331/


*/
namespace source
{


public class EvaluateDivisionSolution   
{


    public double[] CalcEquation(List<List<string>> equations, double[] values, List<List<string>> queries) {

        // equations = [["a","b"],["b","c"]], 
        // values = [2.0,3.0], 
        // queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]

        Dictionary<string,Dictionary<string,double>> graph = new Dictionary<string, Dictionary<string, double>>();

        /* 
                2.0
            a --------> b

                1.0 /2.0
            a <-------- b
        
        */

        //build the graph
        for(int i = 0 ; i < equations.Count; i++){
            var equation = equations[i];
            var divident = equation[0];
            var divisor = equation[1];
            var quotient = values[i];


            if(!graph.ContainsKey(divident)){
                graph.Add(divident, new Dictionary<string, double>());
            }
            

            if(!graph.ContainsKey(divisor)){
                graph.Add(divisor, new Dictionary<string, double>());
            }

            graph[divident].Add(divisor, quotient);
            graph[divisor].Add(divident, 1 / quotient);


        }

        // DFS - verify if a path from diivend to divisor
        // queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]

        double[] results = new double[queries.Count];

        for(int i = 0; i < queries.Count; i++){
            var query = queries[i];
            var divident = query[0];
            var divisor = query[1];
            if( !graph.ContainsKey(divident) || !graph.ContainsKey(divisor)  ){
                results[i] = -1.0;
            }else if( divident == divisor){
                results[i] = 1.0;
            }else{
                HashSet<string> visited = new HashSet<string>();
                results[i] = BackTrackEvaluate(graph,visited,divident,divisor,1);   
            }

        }

        return results;

        
    }

        private double BackTrackEvaluate(Dictionary<string, Dictionary<string, double>> graph, HashSet<string> visited, string currentNode, string targetNode, double accProduct)
        {
            visited.Add(currentNode);
            double result = 1.0;

            Dictionary<string, double> neighbors = graph[currentNode];

            if(neighbors.ContainsKey(targetNode)){
                result = accProduct * neighbors[targetNode];
            }else{
                foreach(var item in neighbors){
                    var nextNode = item.Key;
                    
                    if(visited.Contains(nextNode)) continue;
                    result = BackTrackEvaluate(graph,visited, nextNode,targetNode, accProduct * item.Value);
                    // if valid result, return
                    if(result != -1.0) break;

                }
            }


            return result;



        }



        /*
            https://leetcode.com/problems/evaluate-division/discuss/147281/Java-Union-Find-solution-faster-than-99

             - Method: union find
            - a/b = 2.0 --> b is the root of a; the distance from a to b is 1/2.0
            - if two nums have the same root, we can get the result; a/b=2.0, b/c=3.0
            index   a   b   c
            root    b   c   c 
            dist    2   3   1
            - if we want to know a/c = ?: a = 2 * b = 2 * 3 * c => a/c = 6.0

            https://leetcode.com/problems/evaluate-division/discuss/489392/UnionSet-Neat-Java-Solution

        */
         public double[] CalcEquationUnionFind(List<List<string>> equations, double[] values, List<List<string>> queries) {

             Dictionary<string,string> parentMap = new Dictionary<string, string>();
             Dictionary<string,double> distMap = new Dictionary<string, double>();

             for(int i = 0; i < equations.Count; i++){
                 var equation = equations[i];

                 var dividend = equation[0];
                 var divisor = equation[1];
                 var quotient = values[i];

                 var dividendEntry = Find(parentMap,distMap,dividend);
                 var divisorEntry = Find(parentMap,distMap,divisor);
                 parentMap[dividendEntry] = divisorEntry;

                 distMap[dividendEntry] = (quotient * distMap[divisor]) / distMap[dividend];






             } 

              double[] results = new double[queries.Count];
              for(int i = 0; i <  queries.Count ; i++){
                  var query = queries[i];
                  var dividend = query[0];
                  var divisor = query[1];
                  if(!parentMap.ContainsKey(dividend) || !parentMap.ContainsKey(divisor)){
                      results[i] =  -1.0;  
                  }else{

                        var dividentEntry = Find(parentMap,distMap,dividend);
                        var divisorEntry = Find(parentMap,distMap,divisor);

                        

                        //check if a path does not exist
                        if(dividentEntry != divisorEntry){
                            results[i] = -1.0;
                        }else{

                            var dividentWeight = distMap[dividend];
                            var divisorWeight = distMap[divisor];
                            
                            results[i] = dividentWeight / divisorWeight;
                        }
                  }

              }

              return results;
         }



         

        private string Find(Dictionary<string, string> parentMap, Dictionary<string, double> distMap, string entry)
        {
            if(!parentMap.ContainsKey(entry)){
                parentMap.Add(entry,entry);
                distMap.Add(entry,1.0);
                return entry;
            }

            var parent = parentMap[entry];
            if ( parent == entry ) return entry;

            //collapse logic
            //careful here it is parent not last parent
            distMap[entry] = distMap[entry] *  distMap[parent];

            var lastParent = Find(parentMap,distMap,parent);
            parentMap[entry] = lastParent;
            

            return lastParent;


        }
    }



}
