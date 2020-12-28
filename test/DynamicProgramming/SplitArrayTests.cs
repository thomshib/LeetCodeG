using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class SplitArrayTests
    {
        [Fact]
        public void shoulReturnValidResult(){
            int[] input = new int[]{7,2,5,10,8};

            int m = 2;

            var result = new SplitArraySoluton().SplitArray(input, m);
            Assert.Equal(18,result);

        }

  }

}