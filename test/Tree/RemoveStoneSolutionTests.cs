using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;

namespace test
{

  public class RemoveStonesSolutionTests
    {
        [Fact]
        public void shouldreturnValidResult(){

            int[][] input = new int[][]{
                new int[]{0,0},
                new int[]{0,1},
                new int[]{1,0},
                new int[]{1,2},
                new int[]{2,1},
                new int[]{2,2}
                
                
            };

            var result = new RemoveStonesolution().RemoveStones(input);
            Assert.Equal(5,result);
            
        }

    }
}


