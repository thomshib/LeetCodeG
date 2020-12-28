
using System;
using Xunit;
using source;
using System.Text;

namespace test
{

  public class LongestIncresingPathTests
    {
        //[Fact]
        public void shouldreturnValidCount(){
            
            //  int[][] input = new int[][]{
            //     new int[]{9,9,4},
            //     new int[]{6,6,8},
            //     new int[]{2,1,1}

            // };



             int[][] input = new int[][]{
                new int[]{9,4}

            };

            var result = new LongestIncreasingPathSolution().LongestIncreasingPath(input);
            Assert.Equal(4,result);


        }


    }

}