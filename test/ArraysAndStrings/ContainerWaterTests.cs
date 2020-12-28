using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class ContainerWaterTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {

            int[] height = new int[]{1,8,6,2,5,4,8,3,7};
            int expectedResult = 49;

            var result = ContainerWater.MaxArea(height);
            Assert.Equal(expectedResult,result);
        }

        [Fact]
        public void shouldreturnvalidresultfoTw0PointerMethod()
        {

            int[] height = new int[]{1,8,6,2,5,4,8,3,7};
            int expectedResult = 49;

            var result = ContainerWater.MaxAreaTwoPointers(height);
            Assert.Equal(expectedResult,result);
        }

    }

}