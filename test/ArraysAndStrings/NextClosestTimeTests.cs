using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class NextClosedTimeTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {

           
            string expectedResult = "19:39";

            var result = NextClosestTimeSolution.NextClosestTime("19:34");
            Assert.Equal(expectedResult,result);
        }

        

    }

}