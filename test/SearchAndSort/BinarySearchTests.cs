
using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinarySearchOddInputsResultsinSuccess(){
            int[] input = new int[]{	
                    0, 1, 2, 8, 13, 17, 19, 32, 42};
            int item = 13;

            var result = BinarySearchSolution.binarySearch(input, item);

            Assert.True(result);



        }

         [Fact]
        public void BinarySearchEvenInputsResultsinSuccess(){
            int[] input = new int[]{	
                    0, 1, 2, 8, 13, 17};
            int item = 13;

            var result = BinarySearchSolution.binarySearch(input, item);

            Assert.True(result);



        }
    }
}