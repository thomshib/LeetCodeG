using System;
using Xunit;
using source;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    public class ThreeSumTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {
            int[] nums = new int[] {-1,0,1,2,-1,-4};

            var expectedResult = new List<List<int>>(){
                new List<int>{-1,-1,2} ,
                new List<int>{-1,0,1}
            };

            var result = ThreeSumSolution.ThreeSum(nums);
            Assert.Equal(expectedResult,result);
        }


        //[Fact]
        public void shouldreturnvalidresultfoThreeSumeNoSortMethod()
        {
            int[] nums = new int[] {-1,0,1,2,-1,-4};

            var expectedResult = new List<List<int>>(){
                new List<int>{-1,-1,2} ,
                new List<int>{-1,0,1}
            };

            var result = ThreeSumSolution.ThreeSumWithNoSort(nums);
            Assert.Equal(expectedResult,result);
        }

    }

}