using System;
using Xunit;
using source;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using test.utility;

namespace test
{
    public class PermutationTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {
            var input = new int[]{1,3,5};

            var expectedResult = new List<List<int>>{
                new List<int>{1,3,5}, 
                new List<int>{1,5,3}, 
                new List<int>{3,1,5}, 
                new List<int>{3,5,1}, 
                new List<int>{5,1,3}, 
                new List<int>{5,3,1}
            };


            var result = Permutations.findPermutations(input);
            var listResult = CollectionEquivalence.AreEqual<int>(result,expectedResult);
            Assert.True(listResult);

    }

    [Fact]
    public void shouldreturnvalidresultRorNextPermutation(){

        var input = new int[]{1,2,3};
        var expectedResult = new int[]{1,3,2};

        Permutations.NextPermutation(input);
        Assert.Equal(expectedResult,input);
    }

}
}