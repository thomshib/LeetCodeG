
using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class InsertionSortTests
    {
        [Fact]
        public void InsertionSortResultsinSuccess(){

            int[] input = new int[]{54,26,93,17,77,31,44,55,20};
            int[] expectedResult = new int[]{17, 20, 26, 31, 44, 54, 55, 77, 93};

            InsertionSortSolution.InsertionSort(input);

            Assert.Equal(input,expectedResult);


            
        }
    }
}