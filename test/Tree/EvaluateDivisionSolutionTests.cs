
using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;

namespace test
{

  public class EvaluateDivisionSolutionTests
    {
        [Fact]
        public void shouldreturnValidResult(){

            List<List<string>> equations = new List<List<string>>(){
                new List<string>(){"a","b"},
                new List<string>(){"b","c"} 
                
                
            };

            double[] values = new double[]{2.0,3.0};
            List<List<string>> queries = new List<List<string>>(){
                new List<string>(){"a","c"},
                new List<string>(){"b","a"},
                new List<string>(){"a","e"},
                new List<string>(){"a","a"},
                new List<string>(){"x","x"} 

            };


            var expectedResult = new double[]{6.0,0.50,-1.0,1.0,-1.0};

            var result = new EvaluateDivisionSolution().CalcEquation(equations,values,queries);
            Assert.Equal(expectedResult,result);




        }

        [Fact]
        public void shouldreturnValidResultForUnionFind(){

            List<List<string>> equations = new List<List<string>>(){
                new List<string>(){"a","b"},
                new List<string>(){"b","c"} 
                
                
            };

            double[] values = new double[]{2.0,3.0};
            List<List<string>> queries = new List<List<string>>(){
                new List<string>(){"a","c"},
                new List<string>(){"b","a"},
                new List<string>(){"a","e"},
                new List<string>(){"a","a"},
                new List<string>(){"x","x"} 

            };


            var expectedResult = new double[]{6.0,0.50,-1.0,1.0,-1.0};

            var result = new EvaluateDivisionSolution().CalcEquationUnionFind(equations,values,queries);
            Assert.Equal(expectedResult,result);




        }

    }

}