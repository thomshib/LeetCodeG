using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class SubstringProblemTests
    {
        [Fact]
        public void shouldreturnvalidresultforLengthOfLongestSubstring()
        {
            var input = "abca";
            var expectedResult = 3;
            var result = SubStringProblems.LengthOfLongestSubstring(input);
            Assert.Equal(expectedResult,result);

        }


        [Fact]
        public void shouldreturnvalidresultforLengthOfLongestSubstringOptimized()
        {
            var input = "abca";
            var expectedResult = 3;
            var result = SubStringProblems.LengthOfLongestSubstring(input);
            Assert.Equal(expectedResult,result);

        }


        [Fact]
        public void shouldReturnValidLengthOfLongestSubstringTwoDistinct(){
            string input = "eceba";
            var expectedResult = 3;

            var result = SubStringProblems.LengthOfLongestSubstringTwoDistinct(input);

            Assert.Equal(expectedResult,result);
        }

    }

}