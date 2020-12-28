
using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class LongestPalindromeSubStringTests
    {
        [Fact]
        public void FindLPSLengthRecursive(){

            string input = "pqr";
            

            //  abdba

            var sut = new LongestPalindromeSubStringSolution();

            var result = sut.findLPSLength(input);
            Assert.Equal(1,result);

        }

    }

}



