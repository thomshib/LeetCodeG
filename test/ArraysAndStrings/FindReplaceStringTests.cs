
using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class FindAndReplaceStringTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {
            string S = "abcd"; 
            int[] indexes = new int[]{0, 2};
            string[] sources = new string[] {"a", "cd"};
            string[] targets = new string[] {"eee", "ffff"};
            var expectedResult = "eeebffff";

            var result = FindAndReplaceStringSolution.FindReplaceString(S,indexes,sources,targets);
            Assert.Equal(expectedResult,result);


        }

    }
}