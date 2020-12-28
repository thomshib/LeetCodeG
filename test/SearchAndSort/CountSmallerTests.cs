

using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;

namespace test
{

public class CountSmallerTests{

        [Fact]
        public void MergeortResultsinSuccess(){

            int[] input = new int[]{5,2,6,1};
            var expectedResult = new List<int>{2,1,1,0};


            var result = new CountSmallerSolution().countSmaller(input);

            Assert.Equal(expectedResult,result);


            
        }

}

}