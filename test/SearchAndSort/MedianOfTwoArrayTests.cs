
using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;

namespace test
{


    public class MedianOfTwoArrayTests{
            [Fact]
            public void shouldreturnValidBrackets(){

                int[] input1 = new int[]{1,2};
                int[] input2 = new int[]{3,4};

                var result = new MedianOfTwoArray().findMedian(input1, input2);

                Assert.Equal(2.5, result);

            }
    }

}